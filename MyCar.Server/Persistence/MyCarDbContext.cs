using Microsoft.EntityFrameworkCore;
using MyCar.Server.Core.Models;

namespace MyCar.Server.Persistence
{
    public class MyCarDbContext: DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Make> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Photo> Photos { get; set; }
        
        public MyCarDbContext(DbContextOptions<MyCarDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf =>
            new { vf.VehicleId, vf.FeatureId });
        }
    }
}
 