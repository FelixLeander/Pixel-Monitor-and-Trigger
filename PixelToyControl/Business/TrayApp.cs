using Buttplug.Client;
using PixelToyControl.Data;
using PixelToyControl.Ui;
using Serilog;
using System.Text.Json;

namespace PixelToyControl.Business;

internal sealed class TrayApp : ApplicationContext
{
    private ConfigurationForm? _configruationForm;
    private readonly ButtplugManager _buttplugManager = new();
    private readonly ToolStripMenuItem ToyDevices = new("Toys");
    internal NotifyIcon NotifyIcon { get; set; } = new()
    {
        ContextMenuStrip = new ContextMenuStrip(),
        Icon = new Icon("Assets/favicon.ico"),
        Text = nameof(PixelToyControl),
        Visible = true
    };

    internal TrayApp()
    {
        Log.Verbose("Initalizing {backgroundWroker}.", nameof(TrayApp));
        NotifyIcon.MouseClick += (s, e) =>
        {
            if (e.Button == MouseButtons.Left)
                CreateOrShowConfigurator();
        };

        NotifyIcon.ContextMenuStrip.Items.Add("Open Configurator", null, (_, _) => CreateOrShowConfigurator());
        NotifyIcon.ContextMenuStrip.Items.Add(ToyDevices);
#if DEBUG
        NotifyIcon.ContextMenuStrip.Items.Add("DEBUG: Reset Database", null, (_, _) =>
        {
            using var debugContext = new DatabaseContext();
            debugContext.Database.EnsureDeleted();
            debugContext.Database.EnsureCreated();
        });
#endif
        NotifyIcon.ContextMenuStrip.Items.Add("Stop All", null, (_,_) => _buttplugManager.ButtplugClient.StopAllDevicesAsync());
        NotifyIcon.ContextMenuStrip.Items.Add("Exit", null, (_, _) => ExitApplication());
    }

    internal async Task StartAsync()
    {
        Log.Verbose("Starting scan...");
        await _buttplugManager.ConnectAndScan();
        Log.Verbose("Done scanning.");
    }

    internal void CreateOrShowConfigurator()
    {
        Log.Verbose("Showing {form} value is {variable}", nameof(_configruationForm), _configruationForm == null ? "null" : "filled");

        _configruationForm = (_configruationForm == null || _configruationForm.IsDisposed)
            ? new() { ButtplugManager = _buttplugManager }
            : _configruationForm;

        _configruationForm.Show();

        if (_configruationForm.WindowState == FormWindowState.Minimized)
        {
            Log.Verbose("FormWindowState was minimized, setting it to normal.");
            _configruationForm.WindowState = FormWindowState.Normal;
        }

        Log.Verbose("Focusing form to front.");
        _configruationForm.Activate();
        _configruationForm.BringToFront();
    }

    private void ExitApplication()
    {
        Log.Information("Manual application exit.");

        NotifyIcon.Visible = false;
        Application.Exit();
    }
}
