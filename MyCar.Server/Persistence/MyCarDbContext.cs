using Microsoft.EntityFrameworkCore;
using MyCar.Server.Models;

namespace MyCar.Server.Persistence
{
    public class MyCarDbContext: DbContext
    {
        public MyCarDbContext(DbContextOptions<MyCarDbContext> options): base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
 