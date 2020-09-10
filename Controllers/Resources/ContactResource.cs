using System.Collections.Generic;
using System.Collections.ObjectModel;
using apsnetproject.Models;

namespace apsnetproject.Controllers.Resources
{
    public class ContactResource
    {
        public int Id { get; protected set; }


        public string Name { get; protected set; }


        public string Surname { get; protected set; }


        public string Address { get; protected set; }

        public ICollection<ContactResource> Contacts {get; set;}


        public ContactResource()
        {
            Contacts = new Collection<ContactResource>();
        }
    }
}