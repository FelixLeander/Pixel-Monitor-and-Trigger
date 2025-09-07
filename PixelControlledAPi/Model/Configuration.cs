// Ignore Spelling: Uid Uname Utoken

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelControlledApi.Model;

internal class Configuration
{
    public KeyValuePair<string, string> Token { get; set; }
    public KeyValuePair<string, string> Uid { get; set; }
    public KeyValuePair<string, string> Uname { get; set; }
    public KeyValuePair<string, string> Utoken { get; set; }
}
