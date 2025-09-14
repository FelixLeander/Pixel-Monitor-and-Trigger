using System.Diagnostics;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace InteractiveButtplug.Business;

public sealed class UiWrapper
{

    public static Rgba32 GetPixel(int x, int y)
    {
        var psi = new ProcessStartInfo
        {
            FileName = "grim",
            Arguments = "-",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var proc = Process.Start(psi) ?? throw new Exception("Failed to start process");
        using var image = Image.Load<Rgba32>(proc.StandardOutput.BaseStream);
        proc.WaitForExit();

        if (y < 0 || y >= image.Height)
            throw new ArgumentOutOfRangeException(nameof(y), "Coordinates outside image bounds.");
        if (x < 0 || x >= image.Width)
            throw new ArgumentOutOfRangeException(nameof(x), "Coordinates outside image bounds.");

        return image[x, y];
    }
}