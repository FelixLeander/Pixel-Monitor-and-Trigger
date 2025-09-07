using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelControlledApi.Business;

internal static class Helper
{
    /// <summary>
    /// Apply's the <paramref name="color"/> to the background of the <paramref name="textBox"/>.
    /// Sets the text of <paramref name="textBox"/> to the hexValue of the <paramref name="color"/> and colors
    /// it in a contrasting color based on the provided <paramref name="color"/>.
    /// </summary>
    /// <param name="textBox">the textBox which will be changed.</param>
    /// <param name="color">the color from which the values are taken.</param>
    internal static void ApplyColorWithReadableName(this TextBox textBox, Color color, bool setText = true)
    {
        textBox.BackColor = color;
        textBox.ForeColor = Color.FromArgb(color.R > 127 ? 0 : 255, color.G > 127 ? 0 : 255, color.B > 127 ? 0 : 255);

        if (setText)
            textBox.Text = color.Name;
    }

    /// <summary>
    /// Creates a <see cref="Bitmap"/> from the display.
    /// </summary>
    /// <param name="position">The center position of the screenshot.</param>
    /// <param name="bitmapDimension">The size of the bitmap.</param>
    /// <param name="centerOffset">The offset from the <paramref name="position"/>.</param>
    /// <returns>Gets the part of the image</returns>
    internal static Bitmap MakePartialScreenshot(Point position, int bitmapDimension, int centerOffset)
    {
        var bitmap = new Bitmap(bitmapDimension, bitmapDimension);

        int sX = position.X - centerOffset;
        int sY = position.Y - centerOffset;

        int pX = position.X + centerOffset;
        int pY = position.Y + centerOffset;

        using var g = Graphics.FromImage(bitmap);
        g.CopyFromScreen(sX, sY, 0, 0, new Size(pX, pY));
        return bitmap;
    }
}
