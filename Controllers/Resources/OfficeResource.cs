using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace apsnetproject.Controllers.Resources
{
    public class OfficeResource
    {
       public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<MakeResource> Makes { get; set; }

        public OfficeResource()
        {
            Makes = new Collection<MakeResource>();
        }
    }
}