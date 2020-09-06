using apsnetproject.Controllers.Resources;
using apsnetproject.Models;
using AutoMapper;

namespace apsnetproject.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();

            CreateMap<Office, OfficeResource>();

            CreateMap<Model, ModelResource>();
        }
    }
}