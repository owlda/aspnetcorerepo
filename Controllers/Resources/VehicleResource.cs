using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using apsnetproject.Models;

namespace apsnetproject.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; protected set; }

        public int ModelId { get; protected set; }

        public ICollection<VehicleResource> Vehicles { get; set; }


          public VehicleResource()
        {
            Vehicles = new Collection<VehicleResource>();
        }
    }
}