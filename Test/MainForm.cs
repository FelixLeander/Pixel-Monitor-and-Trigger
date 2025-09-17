using Buttplug.Client;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace Test;

public partial class MainForm : Form
{
    public MainForm() => InitializeComponent();

    private Point PixelPos = new();
    private Color Color = new();

    private readonly ButtplugClient _buttplugClient = new("QuickAndDirty");
    private readonly ButtplugWebsocketConnector _connector = new(new("ws://127.0.0.1:12345"));

    private ButtplugClientDevice _currentDevice;
    private bool _running = false;

    private async void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            Console.WriteLine("Connecting...");

            _buttplugClient.DeviceAdded += async (_, dev) =>
            {
                _currentDevice = dev.Device;
                await _buttplugClient.StopScanningAsync();
            };

            await _buttplugClient.ConnectAsync(_connector);
            await _buttplugClient.StartScanningAsync();
            Console.WriteLine("Dones scanning");

            var result = _buttplugClient.Devices.FirstOrDefault();
            if (result != null)
                _currentDevice = result;

            _ = LoopAsync();

            FillPictureBox(pictureBox2, Color.Green);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"CATASTROPIC FAILURE! {Environment.NewLine}{ex.Message}");
            throw;
        }
    }

    private async void Button1_Click(object sender, EventArgs e)
    {
        FillPictureBox(pictureBox1, Color.Green);

        await Task.Delay(3000);

        PixelPos = Cursor.Position;
        Color = GetColorAtPos(PixelPos);
        FillPictureBox(pictureBox1, Color);
    }

    public static double Similarity(Color c1, Color c2)
    {
        int rDiff = c1.R - c2.R;
        int gDiff = c1.G - c2.G;
        int bDiff = c1.B - c2.B;

        double distance = Math.Sqrt(rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);
        double maxDistance = Math.Sqrt(255 * 255 * 3);

        // normalize: 1.0 = identical, 0.0 = opposite
        var result = 1.0 - (distance / maxDistance);
        Console.WriteLine($"Color distance {result}");
        return result;
    }

    private async void Button2_Click(object sender, EventArgs e)
    {
        _running = !_running;
        button2.Text = _running ? "STOP" : "START";

        if (!_running)
            await _buttplugClient.StopAllDevicesAsync();
    }

    private async Task LoopAsync()
    {
        try
        {
            while (true)
            {
                await Task.Delay(10);
                if (!_running)
                {
                    await Task.Delay(1000);
                    continue;
                }

                var pixel = GetColorAtPos(PixelPos);
                var sim = Similarity(Color, pixel);
                if (sim > 0.9)
                    await _currentDevice.VibrateAsync(0.5);
                else
                    await _currentDevice.VibrateAsync(0);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Loop failure! {Environment.NewLine}{ex.Message}");
            throw;
        }
    }
    private static Color GetColorAtPos(Point pos)
    {
        using var bitmap = new Bitmap(1, 1);
        using var g = Graphics.FromImage(bitmap);
        g.CopyFromScreen(pos.X, pos.Y, 0, 0, new Size(1, 1));
        return bitmap.GetPixel(0, 0);
    }

    private CancellationTokenSource? _cancellationTokenSource;
    private async void Button3_Click(object sender, EventArgs e)
    {
        FillPictureBox(pictureBox2, Color.Green);

        if (_cancellationTokenSource != null)
        {
            Console.WriteLine("stop color-recorder");
            _cancellationTokenSource.Cancel();
            await Task.Delay(300);
            _cancellationTokenSource = null;
            return;
        }

        Console.WriteLine("New color-recorder");
        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationTokenSource.CancelAfter(10000);

        var colors = await Task.Run(async () =>
        {
            var hashSet = new HashSet<Color>();
            var bitmap = new Bitmap(1, 1);
            while (!_cancellationTokenSource.IsCancellationRequested)
            {
                await Task.Delay(100);
                var color = GetColorAtPos(PixelPos);
                hashSet.Add(color);
            }


            return hashSet.ToList();
        });

        pictureBox2.Image = CreateHorizontalColorStripe(colors, pictureBox2.Width, pictureBox2.Height);

        _cancellationTokenSource = null;
        return;

        static Bitmap CreateHorizontalColorStripe(List<Color> colors, int width, int height)
        {
            if (colors == null || colors.Count == 0)
                throw new ArgumentException("Colors list must not be empty.", nameof(colors));

            var bmp = new Bitmap(width, height);
            using (var g = Graphics.FromImage(bmp))
            {
                int segmentWidth = width / colors.Count;
                for (int i = 0; i < colors.Count; i++)
                {
                    int x = i * segmentWidth;
                    int w = (i == colors.Count - 1) ? width - x : segmentWidth; // last segment takes remaining pixels
                    using var brush = new SolidBrush(colors[i]);
                    g.FillRectangle(brush, x, 0, w, height);
                }
            }
            return bmp;
        }
    }

    private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left)
            return;

        var bitmap = pictureBox2.Image as Bitmap ?? throw new Exception("HOW NOT CASTABLE!");
        Color = bitmap.GetPixel(e.X, e.Y);

        FillPictureBox(pictureBox1, Color);
    }

    // DO NOT; FOR THE LOVE OF ALL THAT IS HOWLY, USE THE 'USING' KEYWORD ON BITMAP!
    // IT WILL DISPOSE OF IT CRASH THE APP DOMAIN WITH NO ERROR WHATSOEVER
    private static void FillPictureBox(PictureBox pictureBox, Color color)
    {
        var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        using var g = Graphics.FromImage(bitmap);
        using var brush = new SolidBrush(color);
        g.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);

        pictureBox.Image?.Dispose();
        pictureBox.Image = bitmap;
    }
}
