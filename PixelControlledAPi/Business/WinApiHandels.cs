// Ignore Spelling: SHOWNORMAL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelControlledApi.Business;

internal static partial class WinApiHandels
{
    [LibraryImport("user32", EntryPoint = "RegisterWindowMessageW", StringMarshalling = StringMarshalling.Utf16)]
    public static partial int RegisterWindowMessage(string message);

    [LibraryImport("user32", EntryPoint = "PostMessageA")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

    [LibraryImport("user32.dll", EntryPoint = "ShowWindowA")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [LibraryImport("user32.dll", EntryPoint = "SetForegroundWindowA")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetForegroundWindow(IntPtr hWnd);

    public const int HWND_BROADCAST = 0xffff;
    public const int SW_SHOWNORMAL = 1;
    public static void ShowToFront(IntPtr window)
    {
        ShowWindow(window, SW_SHOWNORMAL);
        SetForegroundWindow(window);
    }

    public static int RegisterWindowMessage(string format, params object[] args)
    {
        string message = string.Format(format, args);
        return RegisterWindowMessage(message);
    }
}