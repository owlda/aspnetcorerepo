using System.ComponentModel.DataAnnotations;

namespace apsnetproject.Models
{
    public class Contact
    {
        public int Id { get; protected set; }

        [Required]
        [StringLength(32)]
        public string Name { get; protected set; }

        [Required]
        [StringLength(32)]
        public string Surname { get; protected set; }

        [Required]
        [StringLength(32)]
        public string Address { get; protected set; }
    }
}