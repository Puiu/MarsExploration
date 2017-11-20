using Infrastructure.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Abstractions
{
    public interface IFlow<T> : IDisposable
    {
        event EventHandler<MeasurementResultEventArgs<T>> OnMeasurementReady;
        CancellationTokenSource CancellationTokenSource { get; set; }

        Task RunFlowAsync();
        void StopFlowRun();
        Task DoMeasureAndSendAsync();
    }
}
