using Microsoft.EntityFrameworkCore;

namespace existencia_core.Models;

public class ExistenciaDbContext : DbContext
{
    public ExistenciaDbContext(DbContextOptions options) : base(options) { }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
        _ = configurationBuilder.Properties<DateTime>().HaveColumnType("timestamp");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) { }
}
