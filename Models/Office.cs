using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace apsnetproject.Models
{
    public class Office
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<Make> Makes { get; set; }

        public Office()
        {
            Makes = new Collection<Make>();
        }

        
    }
}