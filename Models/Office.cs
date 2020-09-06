using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apsnetproject.Models
{
    [Table("Offices")]
    public class Office
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        public ICollection<Make> Makes { get; set; }

        public Office()
        {
            Makes = new Collection<Make>();
        }

        
    }
}