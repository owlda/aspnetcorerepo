using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace apsnetproject.Models
{
    public class Make
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Model> Models {get; set;}

        public int OfficeId { get; set; }

        public Office Office { get; set; }

        public Make() // ctor to initialize the instance of the collection to evoid nullrefexception
        {
            Models = new Collection<Model>();
        }
    }
}