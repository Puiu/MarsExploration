using Infrastructure.Abstractions;
using Infrastructure.Models;
using Serilog.Events;
using System;

namespace Infrastructure.Environment
{
    public class SettingsReader : ISettingsReader
    {
        public LocalSavedMeasurementFileTypeEnum LocalSavedMeasurementFileType => LocalSavedMeasurementFileTypeEnum.JSON;

        public string MeasurementsFolderName => "Measurements";

        public LogEventLevel LogMinimumLevel => LogEventLevel.Debug;

        public string LogFilePathAndName => @"\Logs\mars-exploration-{Date}.log";

        public string ProjectId => "Mars Exploration";

        public string DeviceId => "curiosity-1";

        public string IoTHubUri => "uri";

        public string DeviceKey => "key";

        public int NoOfMillisecondsForLoopInterval => 7;

        public int MeasureTaskMaxDurationInMilliseconds => 5;

        public int NoOfMillisecondsBetweenMeasureSaveRetries => 1000;

        public int NoOfSaveRetries => 1;
    }
}
