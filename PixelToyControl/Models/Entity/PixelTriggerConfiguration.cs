using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixelToyControl.Models.Entity;

[Table(nameof(PixelTriggerConfiguration))]
internal sealed class PixelTriggerConfiguration
{
    [Key]
    public Guid Guid { get; set; }
    public Point Location { get; set; }
    public Color Color { get; set; }
}
