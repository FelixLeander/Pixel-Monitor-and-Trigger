using Buttplug.Client;
using System.ComponentModel;
using Serilog;

namespace PixelToyControl.Business;

public sealed class ButtplugManager
{
    internal ButtplugClient ButtplugClient { get; set; } = new(nameof(PixelToyControl));
    private readonly ButtplugWebsocketConnector _connector = new(new("ws://127.0.0.1:12345"));
    internal BindingList<ButtplugClientDevice> BindingDevices { get; set; } = [];

    // Intiface® Central
    // https://intiface.com/
    internal async Task ConnectAndScan(CancellationToken cancellationToken = default)
    {
        ButtplugClient.DeviceAdded += (s, dev) => BindingDevices.Add(dev.Device);
        ButtplugClient.DeviceRemoved += (s, dev) => BindingDevices.Remove(dev.Device);
        ButtplugClient.ScanningFinished += (s, e) => Log.Verbose("Scanning finished.");
        ButtplugClient.ErrorReceived += (s, error) => Log.Error($"Error: {error.Exception.Message}");
        ButtplugClient.PingTimeout += (s, e) => Log.Verbose("Ping timeout.");

        await ButtplugClient.ConnectAsync(_connector, cancellationToken);
        Log.Information("Connected to server.");

        await ButtplugClient.StartScanningAsync(cancellationToken);
        Log.Information("Scanning complete.");
    }
}
