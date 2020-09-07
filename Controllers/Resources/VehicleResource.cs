using System.ComponentModel.DataAnnotations;
using apsnetproject.Models;

namespace apsnetproject.Controllers.Resources
{
    public class VehicleResorce
    {
        public int Id { get; protected set; }
       [Required]
        public Contact contact { get; protected set; }
       [Required]
        public int ModelId { get; protected set; }
    }
}