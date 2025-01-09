using MyCar.Server.Core.Models;

namespace MyCar.Server.Core
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetPhotos(int vehicleId);
    }
}
