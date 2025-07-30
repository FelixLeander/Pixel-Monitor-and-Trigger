using Microsoft.EntityFrameworkCore;

namespace ProjectMerlin.Data;

internal sealed class ApplicationContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlite($"Data Source={nameof(ProjectMerlin)}Db.sqlite");
}
