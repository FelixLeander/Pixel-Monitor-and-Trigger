using System.Drawing;
using System.Drawing.Imaging.Effects;

namespace ProjectMerlin.Ui;

public partial class MainForm : Form
{
    private Bitmap Bitmap { get; set; } = new Bitmap(100, 100);
    public MainForm() => InitializeComponent();

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private void ListBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
    {
        buttonDeviceRemove.Enabled = listBoxDevices.SelectedValue != null;

        if (listBoxDevices.SelectedValue is not string deviceName)
            return;



    }

    private void NumericUpDownXyCords_ValueChanged(object sender, EventArgs e)
    {
        var (x, y) = ((int)numericUpDownX.Value, (int)numericUpDownY.Value);

        RecordPicture(x, y);
    }

    private async void ButtonPickPosition_Click(object sender, EventArgs e)
    {
        var delay = (int)numericUpDownDelay.Value;
        await Task.Delay(delay * 1000);
        var location = Cursor.Position;

        numericUpDownX.Value = location.X;
        numericUpDownY.Value = location.Y;

        RecordPicture(location.X, location.Y);
    }

    private void RecordPicture(int x, int y)
    {
        const int centerOffset = 50;
        int sX = x - centerOffset;
        int sY = y - centerOffset;

        using var g = Graphics.FromImage(Bitmap);
        g.CopyFromScreen(sX, sY, 0, 0, new Size(100, 100));

        var centerPos = centerOffset / 2;
        var centerColor = Bitmap.GetPixel(centerPos, centerPos);
        var singleColor = new Bitmap(1, 1);
        singleColor.SetPixel(0, 0, centerColor);
        pictureBoxColor.Image = singleColor;
        textBoxHexColor.Text = centerColor.Name;

        ApplyCrosshairMask(Bitmap, Color.Red);
        pictureBoxPreview.Image = Bitmap;

        static void ApplyCrosshairMask(Bitmap bitmap, Color color)
        {
            var hh = bitmap.Height / 2;
            for (int y = 0; y < bitmap.Height; y++)
                bitmap.SetPixel(hh, y, color);

            var wh = bitmap.Width / 2;
            for (int x = 0; x < bitmap.Width; x++)
                bitmap.SetPixel(x, wh, color);
        }
    }

    private void TextBoxHexColor_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            DoShit();
    }

    private void ButtonSetHex_Click(object sender, EventArgs e) => DoShit();

    private void DoShit()
    {

    }
}
