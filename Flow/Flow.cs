using Infrastructure.Abstractions;
using System;
using System.Threading.Tasks;
using Infrastructure.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading;

namespace Flow
{
    public class Flow<T> : IFlow<T>
    {
        /// <summary>
        /// Used for testing the loop functionality
        /// </summary>
        public Exception LoopException { get; set; }

        public event EventHandler<MeasurementResultEventArgs<T>> OnMeasurementReady;
        public CancellationTokenSource CancellationTokenSource { get; set; }


        private readonly IMeasureSource<T> source;
        private readonly ILogger<IFlow<T>> logger;
        private readonly ISettingsReader settings;
        private readonly IMeasureHandler<T> saver;

        private int loopInterval;

        public Flow(IMeasureSource<T> _source,
                            IMeasureHandler<T> _saver,
                            ILogger<IFlow<T>> _logger,
                            ISettingsReader _settings
                            )
        {
            saver = _saver;
            source = _source;
            logger = _logger;
            settings = _settings;

            CancellationTokenSource = new CancellationTokenSource();
            loopInterval = settings.NoOfMillisecondsForLoopInterval;
        }

        

        public async Task RunFlowAsync()
        {
            
            logger.LogInformation("Starting Flow<{0}>", typeof(T).FullName);

            while (!CancellationTokenSource.IsCancellationRequested)
            {
                try
                {
                    logger.LogInformation("Starting a new loop in {0} milliseconds...", loopInterval);
                    await Task.Delay(TimeSpan.FromMilliseconds(loopInterval));

                    //check for previous unsent files
                    //await resender.TryResendMeasuresAsync();

                    await DoMeasureAndSendAsync();

                    logger.LogInformation("Loop finished");
                }
                catch (Exception ex)
                {
                    logger.LogError("Error in Flow<{0}>! Error {1}", typeof(T).FullName, ex);
                    LoopException = ex;
#if DEBUG
                    Debug.WriteLine(ex.ToString());
#endif
                }
            }
        }

        public async Task DoMeasureAndSendAsync()
        {
            

            var measure = await source.DoMeasureAsync();

            OnMeasurementReady?.Invoke(this, new MeasurementResultEventArgs<T> { Measurement = measure });

            logger.LogDebug("Measuring is finished. Proceeding to saving...");

            await saver.HandleAsync(measure);

            logger.LogInformation("Loop succeeded!");
        }

        public void StopFlowRun()
        {

            logger.LogDebug("Stop Flow triggered!");

            if (CancellationTokenSource != null && !CancellationTokenSource.IsCancellationRequested)
                CancellationTokenSource.Cancel();

        }

        public void Dispose()
        {
            logger.LogDebug("Disposing...");
            CancellationTokenSource?.Dispose();
            CancellationTokenSource = null;
        }
    }
}
