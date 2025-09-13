using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixelToyControl.Models;

[Table(nameof(ActionConfig))]
internal sealed class ActionConfig
{
    [Key]
    public Guid Guid { get; set; }
    public string Name { get; set; } = string.Empty;
    public Point Location { get; set; }
    public Color Color { get; set; }

    public override string ToString() => $"X: {Location.X} Y: {Location.Y} - {Name}";
}
