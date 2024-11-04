
using e.Scrap.Entities;
using Microsoft.EntityFrameworkCore;

public class AppSettingsDbContext : DbContext
{
    public DbSet<AltexRefrigerator> AltexRefrigerator { get; private set; }
    public DbSet<AltexGasCooker> AltexGasCooker { get; private set; }

    public AppSettingsDbContext() : base()
    {

    }

    public AppSettingsDbContext(DbContextOptions<AppSettingsDbContext> options) : base(options) 
    {
        
    }
}

