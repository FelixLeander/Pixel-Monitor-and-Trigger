using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace InteractiveButtplug.Business;

internal static class Helper
{
    internal static Logger ConfigureSerilog() => new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File("logs/log.log", LogEventLevel.Information, rollingInterval: RollingInterval.Day)
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Verbose)
                .CreateLogger();
}
