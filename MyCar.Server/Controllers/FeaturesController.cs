using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCar.Server.Controllers.Resources;
using MyCar.Server.Core.Models;
using MyCar.Server.Persistence;

namespace MyCar.Server.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly MyCarDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(MyCarDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
        }
    }
}
