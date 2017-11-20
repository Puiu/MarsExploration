using  System;
using  System.Runtime.CompilerServices;
using  Etg.SimpleStubs;
using Microsoft.Azure.Devices.Client;
using System.Threading.Tasks;
using Infrastructure.Models;
using System.Threading;
using Windows.Storage;
using Microsoft.Extensions.Logging;
using Serilog.Events;

namespace Infrastructure.Abstractions
{
    [CompilerGenerated]
    public class StubIDeviceToCloudMessageHandler<T> : IDeviceToCloudMessageHandler<T>
    {
        private readonly StubContainer<StubIDeviceToCloudMessageHandler<T>> _stubs = new StubContainer<StubIDeviceToCloudMessageHandler<T>>();

        public MockBehavior MockBehavior { get; set; }

        bool global::Infrastructure.Abstractions.IMeasureHandler<T>.MustSaveMeasurementLocallyInCaseOfFailure
        {
            get
            {
                {
                    IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate>("get_MustSaveMeasurementLocallyInCaseOfFailure");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate>("get_MustSaveMeasurementLocallyInCaseOfFailure", out del))
                        {
                            return default(bool);
                        }
                    }

                    return del.Invoke();
                }
            }

            set
            {
                {
                    IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate>("set_MustSaveMeasurementLocallyInCaseOfFailure");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate>("set_MustSaveMeasurementLocallyInCaseOfFailure", out del))
                        {
                            return;
                        }
                    }

                    del.Invoke(value);
                }
            }
        }

        global::Microsoft.Azure.Devices.Client.Message global::Infrastructure.Abstractions.IDeviceToCloudMessageHandler<T>.GetMessageFromMeasure(T measure)
        {
            GetMessageFromMeasure_T_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<GetMessageFromMeasure_T_Delegate>("GetMessageFromMeasure");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<GetMessageFromMeasure_T_Delegate>("GetMessageFromMeasure", out del))
                {
                    return default(global::Microsoft.Azure.Devices.Client.Message);
                }
            }

            return del.Invoke(measure);
        }

        public delegate global::Microsoft.Azure.Devices.Client.Message GetMessageFromMeasure_T_Delegate(T measure);

        public StubIDeviceToCloudMessageHandler<T> GetMessageFromMeasure(GetMessageFromMeasure_T_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Threading.Tasks.Task global::Infrastructure.Abstractions.IDeviceToCloudMessageHandler<T>.SendDeviceToCloudMessageAsync(global::Microsoft.Azure.Devices.Client.Message message)
        {
            SendDeviceToCloudMessageAsync_Message_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<SendDeviceToCloudMessageAsync_Message_Delegate>("SendDeviceToCloudMessageAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<SendDeviceToCloudMessageAsync_Message_Delegate>("SendDeviceToCloudMessageAsync", out del))
                {
                    return Task.FromResult(true);
                }
            }

            return del.Invoke(message);
        }

        public delegate global::System.Threading.Tasks.Task SendDeviceToCloudMessageAsync_Message_Delegate(global::Microsoft.Azure.Devices.Client.Message message);

        public StubIDeviceToCloudMessageHandler<T> SendDeviceToCloudMessageAsync(SendDeviceToCloudMessageAsync_Message_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate bool IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate();

        public StubIDeviceToCloudMessageHandler<T> MustSaveMeasurementLocallyInCaseOfFailure_Get(IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate void IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate(bool value);

        public StubIDeviceToCloudMessageHandler<T> MustSaveMeasurementLocallyInCaseOfFailure_Set(IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Threading.Tasks.Task global::Infrastructure.Abstractions.IMeasureHandler<T>.HandleAsync(T measure)
        {
            IMeasureHandlerOfT_HandleAsync_T_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<IMeasureHandlerOfT_HandleAsync_T_Delegate>("HandleAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<IMeasureHandlerOfT_HandleAsync_T_Delegate>("HandleAsync", out del))
                {
                    return Task.FromResult(true);
                }
            }

            return del.Invoke(measure);
        }

        public delegate global::System.Threading.Tasks.Task IMeasureHandlerOfT_HandleAsync_T_Delegate(T measure);

        public StubIDeviceToCloudMessageHandler<T> HandleAsync(IMeasureHandlerOfT_HandleAsync_T_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIDeviceToCloudMessageHandler(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace Infrastructure.Abstractions
{
    [CompilerGenerated]
    public class StubIFlow<T> : IFlow<T>
    {
        private readonly StubContainer<StubIFlow<T>> _stubs = new StubContainer<StubIFlow<T>>();

        public MockBehavior MockBehavior { get; set; }

        global::System.Threading.CancellationTokenSource global::Infrastructure.Abstractions.IFlow<T>.CancellationTokenSource
        {
            get
            {
                {
                    CancellationTokenSource_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<CancellationTokenSource_Get_Delegate>("get_CancellationTokenSource");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<CancellationTokenSource_Get_Delegate>("get_CancellationTokenSource", out del))
                        {
                            return default(global::System.Threading.CancellationTokenSource);
                        }
                    }

                    return del.Invoke();
                }
            }

            set
            {
                {
                    CancellationTokenSource_Set_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<CancellationTokenSource_Set_Delegate>("set_CancellationTokenSource");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<CancellationTokenSource_Set_Delegate>("set_CancellationTokenSource", out del))
                        {
                            return;
                        }
                    }

                    del.Invoke(value);
                }
            }
        }

        public event global::System.EventHandler<global::Infrastructure.Models.MeasurementResultEventArgs<T>> OnMeasurementReady;

        protected void On_OnMeasurementReady(object sender, global::Infrastructure.Models.MeasurementResultEventArgs<T> args)
        {
            global::System.EventHandler<global::Infrastructure.Models.MeasurementResultEventArgs<T>> handler = OnMeasurementReady;
            if (handler != null) { handler(sender, args); }
        }

        public void OnMeasurementReady_Raise(object sender, global::Infrastructure.Models.MeasurementResultEventArgs<T> args)
        {
            On_OnMeasurementReady(sender, args);
        }

        public delegate global::System.Threading.CancellationTokenSource CancellationTokenSource_Get_Delegate();

        public StubIFlow<T> CancellationTokenSource_Get(CancellationTokenSource_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate void CancellationTokenSource_Set_Delegate(global::System.Threading.CancellationTokenSource value);

        public StubIFlow<T> CancellationTokenSource_Set(CancellationTokenSource_Set_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Threading.Tasks.Task global::Infrastructure.Abstractions.IFlow<T>.RunFlowAsync()
        {
            RunFlowAsync_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<RunFlowAsync_Delegate>("RunFlowAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<RunFlowAsync_Delegate>("RunFlowAsync", out del))
                {
                    return Task.FromResult(true);
                }
            }

            return del.Invoke();
        }

        public delegate global::System.Threading.Tasks.Task RunFlowAsync_Delegate();

        public StubIFlow<T> RunFlowAsync(RunFlowAsync_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Infrastructure.Abstractions.IFlow<T>.StopFlowRun()
        {
            StopFlowRun_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<StopFlowRun_Delegate>("StopFlowRun");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<StopFlowRun_Delegate>("StopFlowRun", out del))
                {
                    return;
                }
            }

            del.Invoke();
        }

        public delegate void StopFlowRun_Delegate();

        public StubIFlow<T> StopFlowRun(StopFlowRun_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Threading.Tasks.Task global::Infrastructure.Abstractions.IFlow<T>.DoMeasureAndSendAsync()
        {
            DoMeasureAndSendAsync_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<DoMeasureAndSendAsync_Delegate>("DoMeasureAndSendAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<DoMeasureAndSendAsync_Delegate>("DoMeasureAndSendAsync", out del))
                {
                    return Task.FromResult(true);
                }
            }

            return del.Invoke();
        }

        public delegate global::System.Threading.Tasks.Task DoMeasureAndSendAsync_Delegate();

        public StubIFlow<T> DoMeasureAndSendAsync(DoMeasureAndSendAsync_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::System.IDisposable.Dispose()
        {
            IDisposable_Dispose_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<IDisposable_Dispose_Delegate>("Dispose");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<IDisposable_Dispose_Delegate>("Dispose", out del))
                {
                    return;
                }
            }

            del.Invoke();
        }

        public delegate void IDisposable_Dispose_Delegate();

        public StubIFlow<T> Dispose(IDisposable_Dispose_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIFlow(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace Infrastructure.Abstractions
{
    [CompilerGenerated]
    public class StubIHeaderHelper : IHeaderHelper
    {
        private readonly StubContainer<StubIHeaderHelper> _stubs = new StubContainer<StubIHeaderHelper>();

        public MockBehavior MockBehavior { get; set; }

        string global::Infrastructure.Abstractions.IHeaderHelper.GetAppVersion()
        {
            GetAppVersion_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<GetAppVersion_Delegate>("GetAppVersion");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<GetAppVersion_Delegate>("GetAppVersion", out del))
                {
                    return default(string);
                }
            }

            return del.Invoke();
        }

        public delegate string GetAppVersion_Delegate();

        public StubIHeaderHelper GetAppVersion(GetAppVersion_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        string global::Infrastructure.Abstractions.IHeaderHelper.TryGetLocalIPAddress()
        {
            TryGetLocalIPAddress_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<TryGetLocalIPAddress_Delegate>("TryGetLocalIPAddress");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<TryGetLocalIPAddress_Delegate>("TryGetLocalIPAddress", out del))
                {
                    return default(string);
                }
            }

            return del.Invoke();
        }

        public delegate string TryGetLocalIPAddress_Delegate();

        public StubIHeaderHelper TryGetLocalIPAddress(TryGetLocalIPAddress_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Threading.Tasks.Task<string> global::Infrastructure.Abstractions.IHeaderHelper.TryGetExternalIPAddressAsync()
        {
            TryGetExternalIPAddressAsync_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<TryGetExternalIPAddressAsync_Delegate>("TryGetExternalIPAddressAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<TryGetExternalIPAddressAsync_Delegate>("TryGetExternalIPAddressAsync", out del))
                {
                    return Task.FromResult(default(string));
                }
            }

            return del.Invoke();
        }

        public delegate global::System.Threading.Tasks.Task<string> TryGetExternalIPAddressAsync_Delegate();

        public StubIHeaderHelper TryGetExternalIPAddressAsync(TryGetExternalIPAddressAsync_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIHeaderHelper(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace Infrastructure.Abstractions
{
    [CompilerGenerated]
    public class StubILocalSaver<T> : ILocalSaver<T>
    {
        private readonly StubContainer<StubILocalSaver<T>> _stubs = new StubContainer<StubILocalSaver<T>>();

        public MockBehavior MockBehavior { get; set; }

        bool global::Infrastructure.Abstractions.IMeasureHandler<T>.MustSaveMeasurementLocallyInCaseOfFailure
        {
            get
            {
                {
                    IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate>("get_MustSaveMeasurementLocallyInCaseOfFailure");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate>("get_MustSaveMeasurementLocallyInCaseOfFailure", out del))
                        {
                            return default(bool);
                        }
                    }

                    return del.Invoke();
                }
            }

            set
            {
                {
                    IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate>("set_MustSaveMeasurementLocallyInCaseOfFailure");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate>("set_MustSaveMeasurementLocallyInCaseOfFailure", out del))
                        {
                            return;
                        }
                    }

                    del.Invoke(value);
                }
            }
        }

        global::System.Threading.Tasks.Task<global::Windows.Storage.StorageFolder> global::Infrastructure.Abstractions.ILocalSaver<T>.GetMeasurementsFolder()
        {
            GetMeasurementsFolder_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<GetMeasurementsFolder_Delegate>("GetMeasurementsFolder");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<GetMeasurementsFolder_Delegate>("GetMeasurementsFolder", out del))
                {
                    return Task.FromResult(default(global::Windows.Storage.StorageFolder));
                }
            }

            return del.Invoke();
        }

        public delegate global::System.Threading.Tasks.Task<global::Windows.Storage.StorageFolder> GetMeasurementsFolder_Delegate();

        public StubILocalSaver<T> GetMeasurementsFolder(GetMeasurementsFolder_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate bool IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate();

        public StubILocalSaver<T> MustSaveMeasurementLocallyInCaseOfFailure_Get(IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate void IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate(bool value);

        public StubILocalSaver<T> MustSaveMeasurementLocallyInCaseOfFailure_Set(IMeasureHandlerOfT_MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Threading.Tasks.Task global::Infrastructure.Abstractions.IMeasureHandler<T>.HandleAsync(T measure)
        {
            IMeasureHandlerOfT_HandleAsync_T_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<IMeasureHandlerOfT_HandleAsync_T_Delegate>("HandleAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<IMeasureHandlerOfT_HandleAsync_T_Delegate>("HandleAsync", out del))
                {
                    return Task.FromResult(true);
                }
            }

            return del.Invoke(measure);
        }

        public delegate global::System.Threading.Tasks.Task IMeasureHandlerOfT_HandleAsync_T_Delegate(T measure);

        public StubILocalSaver<T> HandleAsync(IMeasureHandlerOfT_HandleAsync_T_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubILocalSaver(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace Infrastructure.Abstractions
{
    [CompilerGenerated]
    public class StubIMarsExplorationLogging<T> : IMarsExplorationLogging<T>
    {
        private readonly StubContainer<StubIMarsExplorationLogging<T>> _stubs = new StubContainer<StubIMarsExplorationLogging<T>>();

        public MockBehavior MockBehavior { get; set; }

        void global::Microsoft.Extensions.Logging.ILogger.Log<TState>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, TState state, global::System.Exception exception, global::System.Func<TState, global::System.Exception, string> formatter)
        {
            ILogger_Log_LogLevel_EventId_TState_Exception_FuncOfTStateExceptionString_Delegate<TState> del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<ILogger_Log_LogLevel_EventId_TState_Exception_FuncOfTStateExceptionString_Delegate<TState>>("Log<TState>");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<ILogger_Log_LogLevel_EventId_TState_Exception_FuncOfTStateExceptionString_Delegate<TState>>("Log<TState>", out del))
                {
                    return;
                }
            }

            del.Invoke(logLevel, eventId, state, exception, formatter);
        }

        public delegate void ILogger_Log_LogLevel_EventId_TState_Exception_FuncOfTStateExceptionString_Delegate<TState>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, TState state, global::System.Exception exception, global::System.Func<TState, global::System.Exception, string> formatter);

        public StubIMarsExplorationLogging<T> Log<TState>(ILogger_Log_LogLevel_EventId_TState_Exception_FuncOfTStateExceptionString_Delegate<TState> del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Microsoft.Extensions.Logging.ILogger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel logLevel)
        {
            ILogger_IsEnabled_LogLevel_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<ILogger_IsEnabled_LogLevel_Delegate>("IsEnabled");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<ILogger_IsEnabled_LogLevel_Delegate>("IsEnabled", out del))
                {
                    return default(bool);
                }
            }

            return del.Invoke(logLevel);
        }

        public delegate bool ILogger_IsEnabled_LogLevel_Delegate(global::Microsoft.Extensions.Logging.LogLevel logLevel);

        public StubIMarsExplorationLogging<T> IsEnabled(ILogger_IsEnabled_LogLevel_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.IDisposable global::Microsoft.Extensions.Logging.ILogger.BeginScope<TState>(TState state)
        {
            ILogger_BeginScope_TState_Delegate<TState> del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<ILogger_BeginScope_TState_Delegate<TState>>("BeginScope<TState>");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<ILogger_BeginScope_TState_Delegate<TState>>("BeginScope<TState>", out del))
                {
                    return default(global::System.IDisposable);
                }
            }

            return del.Invoke(state);
        }

        public delegate global::System.IDisposable ILogger_BeginScope_TState_Delegate<TState>(TState state);

        public StubIMarsExplorationLogging<T> BeginScope<TState>(ILogger_BeginScope_TState_Delegate<TState> del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIMarsExplorationLogging(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace Infrastructure.Abstractions
{
    [CompilerGenerated]
    public class StubIMeasureHandler<T> : IMeasureHandler<T>
    {
        private readonly StubContainer<StubIMeasureHandler<T>> _stubs = new StubContainer<StubIMeasureHandler<T>>();

        public MockBehavior MockBehavior { get; set; }

        bool global::Infrastructure.Abstractions.IMeasureHandler<T>.MustSaveMeasurementLocallyInCaseOfFailure
        {
            get
            {
                {
                    MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate>("get_MustSaveMeasurementLocallyInCaseOfFailure");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate>("get_MustSaveMeasurementLocallyInCaseOfFailure", out del))
                        {
                            return default(bool);
                        }
                    }

                    return del.Invoke();
                }
            }

            set
            {
                {
                    MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate>("set_MustSaveMeasurementLocallyInCaseOfFailure");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate>("set_MustSaveMeasurementLocallyInCaseOfFailure", out del))
                        {
                            return;
                        }
                    }

                    del.Invoke(value);
                }
            }
        }

        public delegate bool MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate();

        public StubIMeasureHandler<T> MustSaveMeasurementLocallyInCaseOfFailure_Get(MustSaveMeasurementLocallyInCaseOfFailure_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate void MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate(bool value);

        public StubIMeasureHandler<T> MustSaveMeasurementLocallyInCaseOfFailure_Set(MustSaveMeasurementLocallyInCaseOfFailure_Set_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Threading.Tasks.Task global::Infrastructure.Abstractions.IMeasureHandler<T>.HandleAsync(T measure)
        {
            HandleAsync_T_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<HandleAsync_T_Delegate>("HandleAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<HandleAsync_T_Delegate>("HandleAsync", out del))
                {
                    return Task.FromResult(true);
                }
            }

            return del.Invoke(measure);
        }

        public delegate global::System.Threading.Tasks.Task HandleAsync_T_Delegate(T measure);

        public StubIMeasureHandler<T> HandleAsync(HandleAsync_T_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIMeasureHandler(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace Infrastructure.Abstractions
{
    [CompilerGenerated]
    public class StubIMeasureSource<T> : IMeasureSource<T>
    {
        private readonly StubContainer<StubIMeasureSource<T>> _stubs = new StubContainer<StubIMeasureSource<T>>();

        public MockBehavior MockBehavior { get; set; }

        global::System.Threading.Tasks.Task<T> global::Infrastructure.Abstractions.IMeasureSource<T>.DoMeasureAsync()
        {
            DoMeasureAsync_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<DoMeasureAsync_Delegate>("DoMeasureAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<DoMeasureAsync_Delegate>("DoMeasureAsync", out del))
                {
                    return Task.FromResult(default(T));
                }
            }

            return del.Invoke();
        }

        public delegate global::System.Threading.Tasks.Task<T> DoMeasureAsync_Delegate();

        public StubIMeasureSource<T> DoMeasureAsync(DoMeasureAsync_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIMeasureSource(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace Infrastructure.Abstractions
{
    [CompilerGenerated]
    public class StubIResender<T> : IResender<T>
    {
        private readonly StubContainer<StubIResender<T>> _stubs = new StubContainer<StubIResender<T>>();

        public MockBehavior MockBehavior { get; set; }

        global::Infrastructure.Abstractions.IMeasureHandler<T> global::Infrastructure.Abstractions.IResender<T>.Saver
        {
            get
            {
                {
                    Saver_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<Saver_Get_Delegate>("get_Saver");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<Saver_Get_Delegate>("get_Saver", out del))
                        {
                            return default(global::Infrastructure.Abstractions.IMeasureHandler<T>);
                        }
                    }

                    return del.Invoke();
                }
            }

            set
            {
                {
                    Saver_Set_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<Saver_Set_Delegate>("set_Saver");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<Saver_Set_Delegate>("set_Saver", out del))
                        {
                            return;
                        }
                    }

                    del.Invoke(value);
                }
            }
        }

        public delegate global::Infrastructure.Abstractions.IMeasureHandler<T> Saver_Get_Delegate();

        public StubIResender<T> Saver_Get(Saver_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate void Saver_Set_Delegate(global::Infrastructure.Abstractions.IMeasureHandler<T> value);

        public StubIResender<T> Saver_Set(Saver_Set_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Threading.Tasks.Task global::Infrastructure.Abstractions.IResender<T>.TryResendMeasuresAsync()
        {
            TryResendMeasuresAsync_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<TryResendMeasuresAsync_Delegate>("TryResendMeasuresAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<TryResendMeasuresAsync_Delegate>("TryResendMeasuresAsync", out del))
                {
                    return Task.FromResult(true);
                }
            }

            return del.Invoke();
        }

        public delegate global::System.Threading.Tasks.Task TryResendMeasuresAsync_Delegate();

        public StubIResender<T> TryResendMeasuresAsync(TryResendMeasuresAsync_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIResender(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace Infrastructure.Abstractions
{
    [CompilerGenerated]
    public class StubISettingsReader : ISettingsReader
    {
        private readonly StubContainer<StubISettingsReader> _stubs = new StubContainer<StubISettingsReader>();

        public MockBehavior MockBehavior { get; set; }

        global::Infrastructure.Models.LocalSavedMeasurementFileTypeEnum global::Infrastructure.Abstractions.ISettingsReader.LocalSavedMeasurementFileType
        {
            get
            {
                {
                    LocalSavedMeasurementFileType_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<LocalSavedMeasurementFileType_Get_Delegate>("get_LocalSavedMeasurementFileType");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<LocalSavedMeasurementFileType_Get_Delegate>("get_LocalSavedMeasurementFileType", out del))
                        {
                            return default(global::Infrastructure.Models.LocalSavedMeasurementFileTypeEnum);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        string global::Infrastructure.Abstractions.ISettingsReader.MeasurementsFolderName
        {
            get
            {
                {
                    MeasurementsFolderName_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<MeasurementsFolderName_Get_Delegate>("get_MeasurementsFolderName");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<MeasurementsFolderName_Get_Delegate>("get_MeasurementsFolderName", out del))
                        {
                            return default(string);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        global::Serilog.Events.LogEventLevel global::Infrastructure.Abstractions.ISettingsReader.LogMinimumLevel
        {
            get
            {
                {
                    LogMinimumLevel_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<LogMinimumLevel_Get_Delegate>("get_LogMinimumLevel");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<LogMinimumLevel_Get_Delegate>("get_LogMinimumLevel", out del))
                        {
                            return default(global::Serilog.Events.LogEventLevel);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        string global::Infrastructure.Abstractions.ISettingsReader.LogFilePathAndName
        {
            get
            {
                {
                    LogFilePathAndName_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<LogFilePathAndName_Get_Delegate>("get_LogFilePathAndName");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<LogFilePathAndName_Get_Delegate>("get_LogFilePathAndName", out del))
                        {
                            return default(string);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        string global::Infrastructure.Abstractions.ISettingsReader.ProjectId
        {
            get
            {
                {
                    ProjectId_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<ProjectId_Get_Delegate>("get_ProjectId");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<ProjectId_Get_Delegate>("get_ProjectId", out del))
                        {
                            return default(string);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        string global::Infrastructure.Abstractions.ISettingsReader.DeviceId
        {
            get
            {
                {
                    DeviceId_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<DeviceId_Get_Delegate>("get_DeviceId");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<DeviceId_Get_Delegate>("get_DeviceId", out del))
                        {
                            return default(string);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        string global::Infrastructure.Abstractions.ISettingsReader.IoTHubUri
        {
            get
            {
                {
                    IoTHubUri_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<IoTHubUri_Get_Delegate>("get_IoTHubUri");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<IoTHubUri_Get_Delegate>("get_IoTHubUri", out del))
                        {
                            return default(string);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        string global::Infrastructure.Abstractions.ISettingsReader.DeviceKey
        {
            get
            {
                {
                    DeviceKey_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<DeviceKey_Get_Delegate>("get_DeviceKey");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<DeviceKey_Get_Delegate>("get_DeviceKey", out del))
                        {
                            return default(string);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        int global::Infrastructure.Abstractions.ISettingsReader.NoOfMillisecondsForLoopInterval
        {
            get
            {
                {
                    NoOfMillisecondsForLoopInterval_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<NoOfMillisecondsForLoopInterval_Get_Delegate>("get_NoOfMillisecondsForLoopInterval");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<NoOfMillisecondsForLoopInterval_Get_Delegate>("get_NoOfMillisecondsForLoopInterval", out del))
                        {
                            return default(int);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        int global::Infrastructure.Abstractions.ISettingsReader.MeasureTaskMaxDurationInMilliseconds
        {
            get
            {
                {
                    MeasureTaskMaxDurationInMilliseconds_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<MeasureTaskMaxDurationInMilliseconds_Get_Delegate>("get_MeasureTaskMaxDurationInMilliseconds");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<MeasureTaskMaxDurationInMilliseconds_Get_Delegate>("get_MeasureTaskMaxDurationInMilliseconds", out del))
                        {
                            return default(int);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        int global::Infrastructure.Abstractions.ISettingsReader.NoOfMillisecondsBetweenMeasureSaveRetries
        {
            get
            {
                {
                    NoOfMillisecondsBetweenMeasureSaveRetries_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<NoOfMillisecondsBetweenMeasureSaveRetries_Get_Delegate>("get_NoOfMillisecondsBetweenMeasureSaveRetries");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<NoOfMillisecondsBetweenMeasureSaveRetries_Get_Delegate>("get_NoOfMillisecondsBetweenMeasureSaveRetries", out del))
                        {
                            return default(int);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        int global::Infrastructure.Abstractions.ISettingsReader.NoOfSaveRetries
        {
            get
            {
                {
                    NoOfSaveRetries_Get_Delegate del;
                    if (MockBehavior == MockBehavior.Strict)
                    {
                        del = _stubs.GetMethodStub<NoOfSaveRetries_Get_Delegate>("get_NoOfSaveRetries");
                    }
                    else
                    {
                        if (!_stubs.TryGetMethodStub<NoOfSaveRetries_Get_Delegate>("get_NoOfSaveRetries", out del))
                        {
                            return default(int);
                        }
                    }

                    return del.Invoke();
                }
            }
        }

        public delegate global::Infrastructure.Models.LocalSavedMeasurementFileTypeEnum LocalSavedMeasurementFileType_Get_Delegate();

        public StubISettingsReader LocalSavedMeasurementFileType_Get(LocalSavedMeasurementFileType_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate string MeasurementsFolderName_Get_Delegate();

        public StubISettingsReader MeasurementsFolderName_Get(MeasurementsFolderName_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate global::Serilog.Events.LogEventLevel LogMinimumLevel_Get_Delegate();

        public StubISettingsReader LogMinimumLevel_Get(LogMinimumLevel_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate string LogFilePathAndName_Get_Delegate();

        public StubISettingsReader LogFilePathAndName_Get(LogFilePathAndName_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate string ProjectId_Get_Delegate();

        public StubISettingsReader ProjectId_Get(ProjectId_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate string DeviceId_Get_Delegate();

        public StubISettingsReader DeviceId_Get(DeviceId_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate string IoTHubUri_Get_Delegate();

        public StubISettingsReader IoTHubUri_Get(IoTHubUri_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate string DeviceKey_Get_Delegate();

        public StubISettingsReader DeviceKey_Get(DeviceKey_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate int NoOfMillisecondsForLoopInterval_Get_Delegate();

        public StubISettingsReader NoOfMillisecondsForLoopInterval_Get(NoOfMillisecondsForLoopInterval_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate int MeasureTaskMaxDurationInMilliseconds_Get_Delegate();

        public StubISettingsReader MeasureTaskMaxDurationInMilliseconds_Get(MeasureTaskMaxDurationInMilliseconds_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate int NoOfMillisecondsBetweenMeasureSaveRetries_Get_Delegate();

        public StubISettingsReader NoOfMillisecondsBetweenMeasureSaveRetries_Get(NoOfMillisecondsBetweenMeasureSaveRetries_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate int NoOfSaveRetries_Get_Delegate();

        public StubISettingsReader NoOfSaveRetries_Get(NoOfSaveRetries_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubISettingsReader(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}