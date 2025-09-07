using Buttplug.Client;
using System.ComponentModel;

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
        await ButtplugClient.ConnectAsync(_connector, cancellationToken);

        foreach (var devices in ButtplugClient.Devices)
            BindingListDevices.Add(devices);

        await ButtplugClient.StartScanningAsync(cancellationToken);
    }
}
