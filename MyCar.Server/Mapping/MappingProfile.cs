using AutoMapper;
using MyCar.Server.Controllers.Resources;
using MyCar.Server.Models;

namespace MyCar.Server.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}
