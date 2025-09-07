using PixelControlledApi.Business;
using System.Diagnostics;
using System.Drawing;

namespace PixelControlledApi;

public partial class MainForm : Form
{
    private const int _size = 200;
    private readonly int _halfSize = _size / 2;

    private bool _actionIsInProgress = false;
    private PixelMonitor? _pixelMonitor;
    public MainForm() => InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    }

    private async void Button1_Click(object sender, EventArgs e)
    {
        _actionIsInProgress = true;
        await Task.Delay((int)numericUpDownLocationDelay.Value * 1000);

        var location = Cursor.Position;
        numericUpDownLocationX.Value = location.X;
        numericUpDownLocationY.Value = location.Y;

        LocationMakeScreenshot(location);
        _actionIsInProgress = false;
    }

    private void ButtonToggleObserve_Click(object sender, EventArgs e)
    {
        if (_pixelMonitor == null)
        {
            var point = new Point((int)numericUpDownLocationX.Value, (int)numericUpDownLocationY.Value);
            _pixelMonitor = new PixelMonitor(point, (int)numericUpDownObservingDelay.Value);
            buttonToggleObserve.BackColor = Color.Red;

            _pixelMonitor.PixelColorChanged += (sender, e) =>
            {
                textBoxObservingColor.Invoke(() => textBoxObservingColor.ApplyColorWithReadableName(e.Color));
            };

            _pixelMonitor.StartMonitoring();
        }
        else
        {
            _pixelMonitor.StartMonitoring();
            buttonToggleObserve.BackColor = Color.Green;
            _pixelMonitor = null;
        }
    }

    //Draw red rectangle into center of pictureBox
    private void PictureBox1_Paint(object sender, PaintEventArgs e)
    {
        var cord = new Point(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2);
        using var pen = new Pen(Color.Red, 1);
        var rect = new Rectangle(cord.X, cord.Y, 2, 2);
        e.Graphics.DrawRectangle(pen, rect);
    }

    private void Button1_Click_1(object sender, EventArgs e)
    {
        var colorPicker = new ColorDialog
        {
            Color = textBoxTargetColor.BackColor
        };

        if (colorPicker.ShowDialog() == DialogResult.OK)
            textBoxTargetColor.Text = ColorTranslator.ToHtml(colorPicker.Color);
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
        var text = textBoxTargetColor.Text.Trim();
        if (string.IsNullOrWhiteSpace(text))
            return;

        try
        {
            var color = Enum.TryParse(text, true, out KnownColor knownColor) ? Color.FromKnownColor(knownColor) : ColorTranslator.FromHtml(text);
            textBoxTargetColor.ApplyColorWithReadableName(color, false);
        }
        catch (Exception)
        {
            textBoxTargetColor.BackColor = default;
            MessageBox.Show("Could not set color.");
        }

        /*
        if (Enum.TryParse(text, true, out KnownColor knownColor))
        {
            var color = Color.FromKnownColor(knownColor);
            textBoxTargetColor.ApplyColorWithReadableName(color, false);
            return;
        }

        try
        {
            var color = ColorTranslator.FromHtml(text);
            textBoxTargetColor.ApplyColorWithReadableName(color, false);
        }
        catch (Exception)
        {
            textBoxTargetColor.BackColor = default(Color);
        }
        */
    }

    private void NumericUpDownLocationX_ValueChanged(object sender, EventArgs e)
    {
        if (_actionIsInProgress)
            return;

        var point = new Point((int)numericUpDownLocationX.Value, (int)numericUpDownLocationY.Value);
        LocationMakeScreenshot(point);
    }

    private void LocationMakeScreenshot(Point point)
    {
        var bitmap = Helper.MakePartialScreenshot(point, _size, _halfSize);
        pictureBox1.Image = bitmap;

        var centerColor = bitmap.GetPixel(_halfSize, _halfSize);
        try
        {
            textBoxHexColorLocation.ApplyColorWithReadableName(centerColor);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void AddLinesToScroll(params string[] lines)
    {
        var textBoxLines = textBox1.Text.Split(Environment.NewLine);
        var combined = lines.Concat(textBoxLines).ToList();

        if (combined.Count < 6)
        {
            textBox1.Text = string.Join(Environment.NewLine, combined);
            return;
        }


        var trimmed = combined.SkipLast(Math.Abs(combined.Count - 6)).ToList();
        textBox1.Text = string.Join(Environment.NewLine, trimmed);
    }
}