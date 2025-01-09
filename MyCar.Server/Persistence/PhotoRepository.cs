using Microsoft.EntityFrameworkCore;
using MyCar.Server.Core;
using MyCar.Server.Core.Models;

namespace MyCar.Server.Persistence
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly MyCarDbContext context;

        public PhotoRepository(MyCarDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Photo>> GetPhotos(int vehicleId)
        {
            return await context.Photos
                .Where(p => p.VehicleId == vehicleId)
                .ToListAsync();
        }
    }
}
