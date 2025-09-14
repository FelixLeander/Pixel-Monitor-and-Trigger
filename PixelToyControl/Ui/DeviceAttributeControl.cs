using System.ComponentModel;

namespace PixelToyControl.Ui;

public sealed partial class DeviceAttributeControl : UserControl
{
    public uint Index { get; private init; }
    public DeviceAttributeControl(uint index, string label, uint steps)
    {
        InitializeComponent();
        Index = index;

        labelDescriptor.Text = label;
        trackBarSteps.Maximum = (int)steps;
    }

    private void TrackBarSteps_Scroll(object sender, EventArgs e)
    {
        labelStepValue.Text = trackBarSteps.Value.ToString();
    }
}
