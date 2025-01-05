using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCar.Server.Controllers.Resources;
using MyCar.Server.Core.Models;
using MyCar.Server.Persistence;

namespace MyCar.Server.Controllers
{
    public class MakesController : Controller
    {
        private readonly MyCarDbContext context;
        private readonly IMapper mapper;

        public MakesController(MyCarDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m=>m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}
