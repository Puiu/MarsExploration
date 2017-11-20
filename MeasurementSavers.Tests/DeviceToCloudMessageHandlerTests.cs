
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.Abstractions;
using System.Threading.Tasks;

namespace MeasurementHandlers.Tests
{
    [TestClass]
    public class DeviceToCloudMessageHandlerTests
    {
        [TestMethod]
        public void GetMessage_ExpectedNotNull()
        {
            DeviceToCloudMessageHandler<SomeMeasure> handler = GetHandler();

            var measure = new SomeMeasure() { Temp = 12 };

            var message = handler.GetMessageFromMeasure(measure);

            Assert.IsNotNull(message);
        }


        [TestMethod]
        public async Task SaveMeasure_ExpectedException()
        {
            DeviceToCloudMessageHandler<SomeMeasure> handler = GetHandler();

            var measure = new SomeMeasure() { Temp = 12 };

            await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await handler.HandleAsync(measure));

        }


        [TestMethod]
        public async Task SendDeviceToCloudMessageAsync_ExpectedException()
        {
            DeviceToCloudMessageHandler<SomeMeasure> handler = GetHandler();

            var measure = new SomeMeasure() { Temp = 12 };

            var message = handler.GetMessageFromMeasure(measure);

            await Assert.ThrowsExceptionAsync<NullReferenceException>(async () => await handler.SendDeviceToCloudMessageAsync(message));

        }

        private static DeviceToCloudMessageHandler<SomeMeasure> GetHandler()
        {
            var settingsReader = GetSettingsReader();

            var localSaver = new StubILocalSaver<SomeMeasure>();

            var logger = new StubIMarsExplorationLogging<IDeviceToCloudMessageHandler<SomeMeasure>>();

            var handler = new DeviceToCloudMessageHandler<SomeMeasure>(settingsReader, logger);
            return handler;
        }

        private static StubISettingsReader GetSettingsReader()
        {
            return new StubISettingsReader()
                            .IoTHubUri_Get(() => "uri")
                            .DeviceId_Get(() => "id")
                            .DeviceKey_Get(() => "key")
                            .NoOfMillisecondsBetweenMeasureSaveRetries_Get(() => 100)
                            ;
        }


    }

    class SomeMeasure
    {
        public int Temp { get; set; }

    }
}
