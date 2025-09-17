using Buttplug.Client;
using Buttplug.Core.Messages;
using PixelToyControl.Business;
using PixelToyControl.Data;
using PixelToyControl.Models;
using Serilog;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PixelToyControl.Ui;

public sealed partial class ConfigurationForm : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required ButtplugManager ButtplugManager { get; init; }
    private readonly Bitmap _screenImage;
    public ConfigurationForm()
    {
        InitializeComponent();
        _screenImage = new Bitmap(pictureBoxPreview.Width, pictureBoxPreview.Height);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        listBoxDevices.DataSource = ButtplugManager.BindingDevices;
        listBoxDevices.DisplayMember = nameof(ButtplugClientDevice.Name);

        using var context = new DatabaseContext();
        checkedListBoxActions.Items.AddRange([.. context.ActionConfigs]);
    }

    private void ListBoxDevices_SelectedValueChanged(object sender, EventArgs e)
    {
        Test();
    }

    private void ListBoxDevices_MouseClick(object sender, MouseEventArgs e)
    {
        Test();
    }

    private void Test()
    {
        flowLayoutPanel.Controls.Clear();

        if (listBoxDevices.SelectedItem is not ButtplugClientDevice buttplugClientDevice)
            return;

        foreach (var va in buttplugClientDevice.VibrateAttributes)
        {
            var descritbtion = string.IsNullOrWhiteSpace(va.FeatureDescriptor)
                    ? $"{va.ActuatorType} {va.Index}:"
                    : va.FeatureDescriptor;

            var dac = new DeviceAttributeControl(va.Index, descritbtion, va.StepCount);
            dac.trackBarSteps.Scroll += (_, _)
                =>
            {
                var value = dac.trackBarSteps.Value * 0.01;
                Log.Verbose("VibrateIndex: {index} with value: {value}", va.Index, value);
                buttplugClientDevice.VibrateAsync([va.Index, value]);
            };

            flowLayoutPanel.Controls.Add(dac);
        }
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

    private void CheckedListBoxActions_SelectedValueChanged(object sender, EventArgs e)
    {
        var actionConfig = checkedListBoxActions.SelectedItem as ActionConfig;
        buttonDeleteAction.Enabled = actionConfig != null;
        if (actionConfig == null)
            return;


        Console.WriteLine();
    }

    private void ButtonAddNew_Click(object sender, EventArgs e)
    {
        var actionConfig = new ActionConfig();
        checkedListBoxActions.Items.Add(actionConfig);

        using var context = new DatabaseContext();
        context.ActionConfigs.Add(actionConfig);
        context.SaveChanges();
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        if (checkedListBoxActions.SelectedItem is not ActionConfig actionConfig)
            return;

        checkedListBoxActions.Items.Remove(actionConfig);
        using var context = new DatabaseContext();
        context.ActionConfigs.Remove(actionConfig);
        context.SaveChanges();
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
