using Buttplug.Client;
using PixelToyControl.Business;
using PixelToyControl.Models;
using Serilog;
using System.ComponentModel;

namespace PixelToyControl.Ui;

public partial class ConfigurationForm : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required ButtplugManager ButtplugManager { get; init; }
    private readonly BindingList<ActionConfig> _actionConfigs = [];
    private readonly Bitmap _screenImage;
    public ConfigurationForm()
    {
        InitializeComponent();
        _screenImage = new Bitmap(pictureBoxPreview.Width, pictureBoxPreview.Height);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        listBoxDevices.DataSource = ButtplugManager.BindingListDevices;
        listBoxDevices.DisplayMember = nameof(ButtplugClientDevice.Name);

        Enricher.Sink = (s) => labelLiveLog.Text = s; // Display log at the bottom


    }

    private async void ButtonPickPosition_Click(object sender, EventArgs e)
    {
        try
        {
            buttonPickPosition.Enabled = false;

            var delay = (int)numericUpDownDelay.Value;
            await Task.Delay(delay * 1000);
            var location = Cursor.Position;

            numericUpDownX.ValueChanged -= NumericUpDownXyCords_ValueChanged;
            numericUpDownY.ValueChanged -= NumericUpDownXyCords_ValueChanged;

            numericUpDownX.Value = location.X;
            numericUpDownY.Value = location.Y;

            numericUpDownX.ValueChanged += NumericUpDownXyCords_ValueChanged;
            numericUpDownY.ValueChanged += NumericUpDownXyCords_ValueChanged;

            textBoxHexColor.Text = CreatePreviewPictureGetHexColor(location.X, location.Y);
            SetHexColor();
        }
        finally
        {
            buttonPickPosition.Enabled = true;
        }
    }

    private void NumericUpDownXyCords_ValueChanged(object? sender, EventArgs e)
    {
        var (x, y) = ((int)numericUpDownX.Value, (int)numericUpDownY.Value);

        textBoxHexColor.Text = CreatePreviewPictureGetHexColor(x, y);
        SetHexColor();
    }

    private void PictureBoxPreview_MouseClick(object sender, MouseEventArgs e)
    {
        var heightOffset = e.Y - (pictureBoxPreview.Height / 2);
        var widthOffset = e.X - (pictureBoxPreview.Width / 2);

        numericUpDownX.Value += widthOffset;
        numericUpDownY.Value += heightOffset;
    }

    private void TextBoxHexColor_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            SetHexColor();
        else
            textBoxHexColor.BackColor = default;
    }

    private void ButtonSetHex_Click(object sender, EventArgs e) => SetHexColor();

    private void ListBoxDevices_DoubleClick(object sender, EventArgs e)
    {
        if (listBoxDevices.SelectedItem is not ButtplugClientDevice buttplugClientDevice)
            return;

        Log.Verbose("Opening form {form} with device '{name}'.", nameof(DebugBcdForm), buttplugClientDevice.Name);
        new DebugBcdForm { ButtplugClientDevice = buttplugClientDevice }.ShowDialog();
    }

    private void CheckedListBoxActions_SelectedValueChanged(object sender, EventArgs e)
    {
        if (checkedListBoxActions.SelectedValue is not ActionConfig actionConfig)
            return;

    }

    private void ButtonAddNew_Click(object sender, EventArgs e)
    {
    }

    private void ButtonRemove_Click(object sender, EventArgs e)
    {

    }

    #region Helpers
    private string CreatePreviewPictureGetHexColor(int x, int y)
    {
        var widthOffset = pictureBoxPreview.Width / 2;
        var heightOffset = pictureBoxPreview.Height / 2;
        var sX = x - widthOffset;
        var sY = y - heightOffset;

        using var g = Graphics.FromImage(_screenImage);
        g.CopyFromScreen(sX, sY, 0, 0, new Size(pictureBoxPreview.Width, pictureBoxPreview.Height));

        var centerColor = _screenImage.GetPixel(widthOffset, heightOffset);
        pictureBoxColor.BackColor = centerColor;

        Log.Verbose("Setting preview image.");
        pictureBoxPreview.Image = ApplyCrosshairMask(_screenImage, Color.Red, widthOffset, heightOffset);

        return $"#{centerColor.Name}";
    }

    private void SetHexColor()
    {
        try
        {
            var color = Enum.TryParse(textBoxHexColor.Text, true, out KnownColor knownColor)
                ? Color.FromKnownColor(knownColor)
                : ColorTranslator.FromHtml(textBoxHexColor.Text);

            pictureBoxColor.BackColor = color;
            textBoxHexColor.BackColor = Color.LightGreen;
        }
        catch
        {
            textBoxHexColor.BackColor = Color.OrangeRed;
        }
    }

    private static Bitmap ApplyCrosshairMask(Bitmap bitmap, Color color, int x, int y)
    {
        for (var h = 0; h < bitmap.Height; h++)
            bitmap.SetPixel(x, h, color);

        for (var w = 0; w < bitmap.Width; w++)
            bitmap.SetPixel(w, y, color);

        return bitmap;
    }
    #endregion
}
