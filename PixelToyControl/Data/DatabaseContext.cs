using Microsoft.EntityFrameworkCore;
using PixelToyControl.Models;

namespace PixelToyControl.Data;

internal sealed class DatabaseContext : DbContext
{
    DbSet<ActionConfig> ActionConfigs => Set<ActionConfig>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={nameof(PixelToyControl)}Db.sqlite");
}
