using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelControlledApi.Model;

internal class PixelMonitor
{
    private readonly Point pixelLocation;
    private readonly Thread monitorThread;
    internal int _delay;

    private bool isMonitoring;

    // Event declaration
    public event EventHandler<ColorEventArgs>? PixelColorChanged;

    // Constructor
    public PixelMonitor(Point location, int delay)
    {
        pixelLocation = location;
        _delay = delay;

        monitorThread = new Thread(MonitorPixelColor);
    }

    // Start monitoring the pixel color
    public void StartMonitoring()
    {
        if (isMonitoring)
            return;

        isMonitoring = true;
        monitorThread.Start();
    }

    // Stop monitoring the pixel color
    public void StopMonitoring()
    {
        if (!isMonitoring)
            return;

        isMonitoring = false;
        monitorThread.Join();
    }

    private void MonitorPixelColor()
    {
        while (isMonitoring)
        {
            var currentColor = GetPixelColor(pixelLocation);
            PixelColorChanged?.Invoke(this, new ColorEventArgs { Color = currentColor });

            Thread.Sleep(_delay);
        }
    }

    private static Color GetPixelColor(Point location)
    {
        var screenBitmap = new Bitmap(1, 1);
        using (var g = Graphics.FromImage(screenBitmap))
        {
            g.CopyFromScreen(location, Point.Empty, new Size(1, 1));
        }

        return screenBitmap.GetPixel(0, 0);
    }
}