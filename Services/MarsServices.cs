using System;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Abstractions;
using Windows.Storage;
using Serilog;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Infrastructure.Environment;
using MeasurementHandlers;
using MeasurementSources;
using flow = Flow;
using Infrastructure.Models;

namespace Services
{

    public static class MarsServices
    {
        public static IServiceProvider Services { get; private set; }

        static MarsServices()
        {
            ConfigureServices();
        }

        public static void ConfigureServices()
        {
            RegisterImplementations();

            ConfigureLogger();
        }

        private static void RegisterImplementations()
        {
            var services = new ServiceCollection()
                        .AddLogging()

                        .AddSingleton<ISettingsReader, SettingsReader>()

                        .AddScoped<IHeaderHelper, HeaderHelper>()

                        
                        .AddTransient(typeof(IMeasureHandler<>), typeof(DeviceToCloudMessageHandler<>))

                        .AddTransient<IMeasureSource<SoilTelemetry>, SoilAnalyzer>()

                        .AddTransient(typeof(IFlow<>), typeof(flow.Flow<>))
                        ;

            Services = services.BuildServiceProvider();
        }

        private static void ConfigureLogger()
        {
            var settingsReader = Services.GetService<ISettingsReader>();

            string logFilPath = GetFullFilePath(settingsReader);


            Log.Logger = new LoggerConfiguration()

               .MinimumLevel.ControlledBy(new Serilog.Core.LoggingLevelSwitch() { MinimumLevel = settingsReader.LogMinimumLevel })

               .WriteTo.RollingFile(logFilPath)

               .CreateLogger();

            //https://github.com/serilog/serilog/wiki/Debugging-and-Diagnostics
            Serilog.Debugging.SelfLog.Enable(msg => Debug.WriteLine(msg));

            var loggerFactory = Services.GetRequiredService<ILoggerFactory>();
            loggerFactory.AddSerilog();
        }

        private static string GetFullFilePath(ISettingsReader settingsReader)
        {
            StorageFolder appLocalFolder = ApplicationData.Current.LocalFolder;
            var logFilPath = appLocalFolder.Path + settingsReader.LogFilePathAndName;
            return logFilPath;
        }
    }
}
