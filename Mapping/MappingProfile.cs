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

            CreateMap<Contact, ContactResource>();
            
           
           // From API to Domain (DB)
           CreateMap<ContactResource, Contact>();
           
        }
    }
}