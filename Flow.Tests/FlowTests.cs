using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Infrastructure.Abstractions;

namespace Flow.Tests
{
    [TestClass]
    public class FlowTests
    {
        [TestMethod]
        public async Task DoMeasureAndSendAsync_ExpectedDoMeasureException()
        {
            var errorText = "Forced exception!";

            var settingsReader = GetSettingsReader();

            var localSaver = new StubILocalSaver<SomeMeasure>();

            var measureSource = new StubIMeasureSource<SomeMeasure>()
                .DoMeasureAsync(() => throw new DoMeasureException(errorText));

            var measureSaver = new StubIMeasureHandler<SomeMeasure>();

            var resender = new StubIResender<SomeMeasure>();

            var logger = new StubIMarsExplorationLogging<StubIFlow<SomeMeasure>>();


            var flow = new Flow<SomeMeasure>(measureSource, measureSaver, logger, settingsReader);

            await Assert.ThrowsExceptionAsync<DoMeasureException>(async () => await flow.DoMeasureAndSendAsync());
        }


        [TestMethod]
        public async Task DoMeasureAndSendAsync_ExpectedSaveMeasureException()
        {
            Flow<SomeMeasure> flow = GetFlowWithSaveMeasureException();

            await Assert.ThrowsExceptionAsync<SaveMeasureException>(async () => await flow.DoMeasureAndSendAsync());
        }



        [TestMethod]
        public async Task RunFlowAsync_ExpectedSaveMeasureException()
        {

            Flow<SomeMeasure> flow = GetFlowWithSaveMeasureException();


            var tsk = flow.RunFlowAsync();

            await Task.Delay(1000);

            Assert.IsInstanceOfType(flow.LoopException, typeof(SaveMeasureException));
        }

        [TestMethod]
        public void StopFlowRun_ExpectedCancelledCancellationTokenSource()
        {
            Flow<SomeMeasure> flow = GetFlowWithSaveMeasureException();

            flow.StopFlowRun();

            Assert.IsTrue(flow.CancellationTokenSource.IsCancellationRequested);
        }

        [TestMethod]
        public void Dispose_ExpectedNullCancellationTokenSource()
        {

            Flow<SomeMeasure> flow = GetFlowWithSaveMeasureException();
            flow.Dispose();

            Assert.IsNull(flow.CancellationTokenSource);

        }

        private static Flow<SomeMeasure> GetFlowWithSaveMeasureException()
        {
            var errorText = "Forced exception!";

            var settingsReader = GetSettingsReader();

            var localSaver = new StubILocalSaver<SomeMeasure>();

            var measureSource = new StubIMeasureSource<SomeMeasure>();


            var measureSaver = new StubIMeasureHandler<SomeMeasure>()
                .HandleAsync((whatever) => throw new SaveMeasureException(errorText));

            var resender = new StubIResender<SomeMeasure>();

            var logger = new StubIMarsExplorationLogging<StubIFlow<SomeMeasure>>();

            var flow = new Flow<SomeMeasure>(measureSource, measureSaver, logger, settingsReader);
            return flow;
        }

        private static StubISettingsReader GetSettingsReader()
        {
            return new StubISettingsReader()
                            .NoOfMillisecondsForLoopInterval_Get(() => 100)
                            ;
        }
    }

    class SomeMeasure
    {
        public int Temp { get; set; }

    }

    class DoMeasureException : Exception
    {
        public DoMeasureException()
        {
        }

        public DoMeasureException(string message) : base(message)
        {
        }
    }

    class SaveMeasureException : Exception
    {
        public SaveMeasureException()
        {
        }

        public SaveMeasureException(string message) : base(message)
        {
        }
    }

}
