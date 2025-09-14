using Buttplug.Client;
using InteractiveButtplug.Business;
using Microsoft.Win32;
using Serilog;

try
{
    Log.Logger = Helper.ConfigureSerilog();
    Log.Verbose("Initalizing...");

    var buttplugClient = new ButtplugClient(nameof(InteractiveButtplug));
    var connector = new ButtplugWebsocketConnector(new("ws://127.0.0.1:12345"));

    await buttplugClient.ConnectAsync(connector);
    Log.Information("Connected to server.");

    if (buttplugClient.Devices.Length == 0)
    {
        Log.Information("No devices. Ensure the device is connected first.");
        return;
    }
    Log.Information("Found {n} devices.", buttplugClient.Devices.Length);

    buttplugClient.Devices.ToList().ForEach(f => Log.Verbose($"{f.Index}: {f.Name}"));


    await Task.Delay(Timeout.Infinite);
}
catch (Exception ex)
{
    Log.Fatal(ex, "Fatal error.");
}
finally
{
    Log.Verbose("Ending application.");
}
