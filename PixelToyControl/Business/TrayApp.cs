using Buttplug.Client;
using PixelToyControl.Models.Entity;
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

        _buttplugManager.ButtplugClient.DeviceRemoved += (s, dev) => ToyDevices.DropDownItems.RemoveByKey(dev.Device.DisplayName);
        _buttplugManager.ButtplugClient.DeviceAdded += (s, dev) =>
        {
            var tsb = new ToolStripButton(dev.Device.DisplayName)
            {
                CheckState = CheckState.Checked,
            };
            ToyDevices.DropDownItems.Insert(-1, tsb);
        };

        NotifyIcon.ContextMenuStrip.Items.Add("Open Configurator", null, (s, e) => CreateOrShowConfigurator());
        NotifyIcon.ContextMenuStrip.Items.Add(ToyDevices);
        NotifyIcon.ContextMenuStrip.Items.Add("Exit", null, (s, e) => ExitApplication());
    }

    internal async Task StartAsync()
    {
        Log.Verbose("Starting scan...");
        await _buttplugManager.ConnectAndScan();

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
