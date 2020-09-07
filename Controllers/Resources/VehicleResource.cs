using System.ComponentModel.DataAnnotations;
using apsnetproject.Models;

namespace apsnetproject.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; protected set; }

       [Required]
        public int ModelId { get; protected set; }
    }
}