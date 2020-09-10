using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apsnetproject.Models
{
    [Table("Contacts")]
    public class Contact
    {
        public int Id { get; set; }

        
        [StringLength(32)]
        public string Name { get; set; }

        
        [StringLength(32)]
        public string Surname { get; set; }

        
        [StringLength(32)]
        public string Address { get; set; }

        
    }
}