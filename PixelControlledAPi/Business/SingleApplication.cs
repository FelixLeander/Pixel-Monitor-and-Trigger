using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PixelControlledApi.Business;

internal static class SingleApplication
{
    static public string AssemblyGuid
    {
        get
        {
            var attributes = Assembly.GetEntryAssembly()?.GetCustomAttributes(typeof(System.Runtime.InteropServices.GuidAttribute), false);
            if (attributes == null || attributes.Length == 0)
                return string.Empty;

            return ((System.Runtime.InteropServices.GuidAttribute)attributes[0]).Value;
        }
    }

    private static Mutex? _mutex;
    internal static bool IsUnique()
    {
        _mutex?.ReleaseMutex();
        _mutex?.Dispose();

        _mutex = new Mutex(true, @"Global\FlandersPCA", out bool createdNew);
        return createdNew;
    }
}
