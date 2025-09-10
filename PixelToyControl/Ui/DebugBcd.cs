using Buttplug.Client;
using System.ComponentModel;

namespace PixelToyControl.Ui;

public partial class DebugBcd : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required ButtplugClientDevice ButtplugClientDevice { get; set; }

    public DebugBcd() => InitializeComponent();

    private void DebugBcd_Load(object sender, EventArgs e)
    {
        foreach (var item in ButtplugClientDevice.LinearAttributes)
        {

        }

        foreach (var item in ButtplugClientDevice.OscillateAttributes)
        {

        }

        foreach (var item in ButtplugClientDevice.RotateAttributes)
        {

        }

        foreach (var item in ButtplugClientDevice.VibrateAttributes)
        {

        }
    }
}
