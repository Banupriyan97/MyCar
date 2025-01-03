using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCar.Server.Models;
using MyCar.Server.Persistence;

namespace MyCar.Server.Controllers
{
    public class MakesController : Controller
    {
        private MyCarDbContext context { get; set; }

        public MakesController(MyCarDbContext context)
        {
            this.context = context; 
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m=>m.Models).ToListAsync();
        }
    }
}
