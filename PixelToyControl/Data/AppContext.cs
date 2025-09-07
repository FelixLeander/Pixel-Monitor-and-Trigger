using Microsoft.EntityFrameworkCore;
using PixelToyControl.Models.Entity;

namespace PixelToyControl.Data;

internal sealed class AppContext : DbContext
{
    DbSet<PixelTriggerConfiguration> PixelTriggerConfigurations => Set<PixelTriggerConfiguration>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={nameof(PixelToyControl)}Db.sqlite");
}
