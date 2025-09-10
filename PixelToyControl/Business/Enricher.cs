using Serilog.Core;
using Serilog.Events;

namespace PixelToyControl.Business;

internal class Enricher : ILogEventEnricher
{
    internal static Action<string>? Sink { get; set; }

    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        if (Sink != null && logEvent.Level > LogEventLevel.Verbose)
            Sink(logEvent.RenderMessage());
    }
}
