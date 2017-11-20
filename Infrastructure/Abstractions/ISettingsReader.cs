using Infrastructure.Models;
using Serilog.Events;

namespace Infrastructure.Abstractions
{
    public interface ISettingsReader
    {
        LocalSavedMeasurementFileTypeEnum LocalSavedMeasurementFileType { get; }

        string MeasurementsFolderName { get; }

        LogEventLevel LogMinimumLevel { get; }
        string LogFilePathAndName { get; }

        string ProjectId { get; }
        string DeviceId { get; }

        string IoTHubUri { get; }

        string DeviceKey { get; }

        int NoOfMillisecondsForLoopInterval { get; }
        int MeasureTaskMaxDurationInMilliseconds { get; }
        int NoOfMillisecondsBetweenMeasureSaveRetries { get; }
        int NoOfSaveRetries { get; }
    }
}
