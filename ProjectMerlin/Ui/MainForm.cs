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

        textBoxHexColor.Text = CreatePreviewPictureGetHexColor(x, y);
        SetHexColor();
    }

    private async void ButtonPickPosition_Click(object sender, EventArgs e)
    {
        try
        {
            buttonPickPosition.Enabled = false;

            var delay = (int)numericUpDownDelay.Value;
            await Task.Delay(delay * 1000);
            var location = Cursor.Position;

            numericUpDownX.Value = location.X;
            numericUpDownY.Value = location.Y;

            textBoxHexColor.Text = CreatePreviewPictureGetHexColor(location.X, location.Y);
            SetHexColor();
        }
        finally
        {
            buttonPickPosition.Enabled = true;
        }
    }

    private string CreatePreviewPictureGetHexColor(int x, int y)
    {
        int widthOffset = pictureBoxPreview.Width / 2;
        int heightOffset = pictureBoxPreview.Height / 2;
        int sX = x - widthOffset;
        int sY = y - widthOffset;

        using var g = Graphics.FromImage(Bitmap);
        g.CopyFromScreen(sX, sY, 0, 0, new Size(pictureBoxPreview.Width, pictureBoxPreview.Height));

        var centerColor = Bitmap.GetPixel(widthOffset, heightOffset);
        pictureBoxColor.BackColor = centerColor;

        pictureBoxPreview.Image = ApplyCrosshairMask(Bitmap, Color.Red, widthOffset, heightOffset);

        return $"#{centerColor.Name}";
    }

    private void PictureBoxPreview_MouseClick(object sender, MouseEventArgs e)
    {
        int heightOffset = e.Y - (pictureBoxPreview.Height / 2);
        int widthOffset = e.X - (pictureBoxPreview.Width / 2);

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
        for (int h = 0; h < bitmap.Height; h++)
            bitmap.SetPixel(x, h, color);

        for (int w = 0; w < bitmap.Width; w++)
            bitmap.SetPixel(w, y, color);

        return bitmap;
    }
}
