using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apsnetproject.Models
{
     [Table("Vehicles")]
    public class Vehicle
    {
        public int Id { get; protected set; }

        [Required]
        public int ModelId { get;  protected set; }

        
    }
}