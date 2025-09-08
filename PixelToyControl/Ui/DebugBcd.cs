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
        var list = ButtplugClientDevice.VibrateAttributes;
    }
}
