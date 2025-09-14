using Microsoft.EntityFrameworkCore;
using PixelToyControl.Models;

namespace PixelToyControl.Data;

internal sealed class DatabaseContext : DbContext
{
    internal DbSet<ActionConfig> ActionConfigs => Set<ActionConfig>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={nameof(PixelToyControl)}Db.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var actionConfig = modelBuilder.Entity<ActionConfig>();

        actionConfig.Property(e => e.Color).HasConversion(
            color => ColorTranslator.ToHtml(color),
            text => ColorTranslator.FromHtml(text)
        );
    }
}
