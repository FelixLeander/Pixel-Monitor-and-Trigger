using InteractiveButtplug.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveButtplug.Data;

internal sealed class DatabaseContext : DbContext
{
    internal DbSet<ActionConfig> ActionConfigs => Set<ActionConfig>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={AppContext.BaseDirectory}/{nameof(InteractiveButtplug)}Db.sqlite");
}