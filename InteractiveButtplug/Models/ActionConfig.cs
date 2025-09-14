using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace InteractiveButtplug.Models;

[Table(nameof(ActionConfig))]
internal sealed class ActionConfig
{
    [Key]
    public Guid Guid { get; set; }
    public string Name { get; set; } = string.Empty;
    public int X { get; set; }
    public int Y { get; set; }
    public Color Color { get; set; }

    public override string ToString() => $"X: {X} Y: {Y} - {Name}";
}
