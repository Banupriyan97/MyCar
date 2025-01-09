using System.ComponentModel.DataAnnotations;

namespace MyCar.Server.Controllers.Resources
{
    public class PhotoResource
    {
        public int Id { get; set; }
        public string FileName { get; set; }
    }
}
