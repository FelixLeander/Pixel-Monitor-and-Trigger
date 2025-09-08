using Buttplug.Client;
using System.ComponentModel;
using Serilog;

namespace PixelToyControl.Business;

public sealed class ButtplugManager
{
    internal ButtplugClient ButtplugClient { get; set; } = new(nameof(PixelToyControl));
    private readonly ButtplugWebsocketConnector _connector = new(new("ws://127.0.0.1:12345"));
    internal BindingList<ButtplugClientDevice> BindingListDevices { get; set; } = [];

    // Intiface® Central
    // https://intiface.com/
    internal async Task ConnectAndScan(CancellationToken cancellationToken = default)
    {
        ButtplugClient.DeviceAdded += (s, dev) => BindingListDevices.Add(dev.Device);
        ButtplugClient.DeviceRemoved += (s, dev) => BindingListDevices.Remove(dev.Device);
        ButtplugClient.ScanningFinished += (s, e) => Log.Verbose("Stopped scanning.");
        ButtplugClient.ErrorReceived += (s, error) => Log.Error($"Error: {error.Exception.Message}");
        ButtplugClient.PingTimeout += (s, e) => Log.Verbose("Ping timeout.");

        await ButtplugClient.ConnectAsync(_connector, cancellationToken);

        foreach (var device in ButtplugClient.Devices)
        {
            Log.Information($"Added device; '{device.DisplayName}:{device.Name}:{device.Index}'");
            BindingListDevices.Add(device);
        }

        await ButtplugClient.StartScanningAsync(cancellationToken);
    }

}
