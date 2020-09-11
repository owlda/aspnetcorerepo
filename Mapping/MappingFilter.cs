using apsnetproject.Controllers.Resources;
using AutoMapper;

namespace apsnetproject.Mapping
{
    public class MappingFilter: Profile
    {
        public MappingFilter()
        {
            // API Resources to Domain models -> DB
            CreateMap<FilterContactResource, ContactResource>();

            // Domain models -> API Resources
            CreateMap<ContactResource, FilterContactResource>();
        }
    }
}