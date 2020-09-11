using apsnetproject.Controllers.Resources;
using apsnetproject.Models;
using AutoMapper;

namespace apsnetproject.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // From Domain DB to API
            CreateMap<Make, MakeResource>();

            CreateMap<Office, OfficeResource>();

            CreateMap<Model, ModelResource>();

            CreateMap<Contact, ContactResource>();

            CreateMap<Contact, FilterResource>();
            
           
           // From API to Domain (DB)
           CreateMap<ContactResource, Contact>();
           
        }
    }
}