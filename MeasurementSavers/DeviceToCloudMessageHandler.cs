using Infrastructure.Abstractions;
using System;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Microsoft.Extensions.Logging;
using Polly;
using Newtonsoft.Json;
using System.Text;

namespace MeasurementHandlers
{
    public class DeviceToCloudMessageHandler<T> : IDeviceToCloudMessageHandler<T>
    {
        public bool MustSaveMeasurementLocallyInCaseOfFailure { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private DeviceClient deviceClient;
        private Message deviceToCloudMessage;
        private ISettingsReader settingsReader;
        private ILogger logger;

        private string iotHubUri = "";
        private string deviceKey = "";
        private string deviceId = "";

        public DeviceToCloudMessageHandler(ISettingsReader _reader, ILogger<IDeviceToCloudMessageHandler<T>> _logger) 
        {
            settingsReader = _reader;
            logger = _logger;

            iotHubUri = settingsReader.IoTHubUri;
            deviceKey = settingsReader.DeviceKey;
            deviceId = settingsReader.DeviceId;
        }

        public async Task HandleAsync(T measure)
        {
            logger.LogInformation("Saving to IoTHub...");
            try
            {
                deviceClient = DeviceClient.Create(iotHubUri, new DeviceAuthenticationWithRegistrySymmetricKey(deviceId, deviceKey));

                deviceToCloudMessage = GetMessageFromMeasure(measure);

                await RetryPolicy().ExecuteAsync(() => SendDeviceToCloudMessageAsync(deviceToCloudMessage));
            }
            finally
            {
                deviceToCloudMessage?.Dispose();
            }
        }

        public Message GetMessageFromMeasure(T measure)
        {
            var messageString = JsonConvert.SerializeObject(measure);

            var message = new Message(Encoding.ASCII.GetBytes(messageString));
            message.Properties.Add("measure", measure.GetType().Name);
            return message;
        }

        private Polly.Retry.RetryPolicy RetryPolicy()
        {
            return Policy
                   .Handle<Exception>()
                   .WaitAndRetryAsync(settingsReader.NoOfSaveRetries, count =>
                   {
                       return TimeSpan.FromMilliseconds(settingsReader.NoOfMillisecondsBetweenMeasureSaveRetries);
                   },
                   onRetry: (exception, timespan, retryCount, context) =>
                   {
                       logger.LogError("Error sending to IoTHub. Retry no.: {0}; Exception: {1}", retryCount, exception.Message);
                   });
        }

        public async Task SendDeviceToCloudMessageAsync(Message message)
        {
            try
            {    
                logger.LogDebug("Sending Message to IoT Hub");
                await deviceClient.SendEventAsync(message);
            }
            finally
            {
                deviceClient?.Dispose();
            }
        }
    }
}
