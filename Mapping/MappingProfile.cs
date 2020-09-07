using apsnetproject.Controllers.Resources;
using apsnetproject.Models;
using AutoMapper;

namespace apsnetproject.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // From Domain to API
            CreateMap<Make, MakeResource>();

            CreateMap<Office, OfficeResource>();

            CreateMap<Model, ModelResource>();

            CreateMap<Vehicle, VehicleResource>()
            .ForMember(v => v.ModelId, opt => opt.MapFrom(vr => vr.ModelId));
           
           // From API to Domain (DB)
            CreateMap<VehicleResource, Vehicle>()
            .ForMember(v => v.ModelId, opt => opt.MapFrom(vr => vr.ModelId));
        }
    }
}