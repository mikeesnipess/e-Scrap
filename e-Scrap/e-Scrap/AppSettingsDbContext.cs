using e.Scrap.Entities.eMag;
using e_Scrap.Entities;
using e_Scrap.Entities.Altex;
using e_Scrap.Entities.eMag;
using Entities.Altex;
using Microsoft.EntityFrameworkCore;

public class AppSettingsDbContext : DbContext
{
    public DbSet<AltexRefrigerator> AltexRefrigerator { get; private set; }
    public DbSet<AltexGasCooker> AltexGasCooker { get; private set; }
    public DbSet<AltexWashMachine> AltexWashMachine { get; private set; }
    public DbSet<eMagGasCooker> eMagGasCooker { get; private set; }
    public DbSet<eMagRefrigerator> eMagRefrigerator { get; private set; }
    public DbSet<eMagWashMachine> eMagWashMachine { get; private set; }
    public DbSet<Shops> Shops { get; private set; }

    public AppSettingsDbContext() : base()
    {

    }

    public AppSettingsDbContext(DbContextOptions<AppSettingsDbContext> options) : base(options) 
    {
        
    }
}

