using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace apsnetproject.Models
{
    public class Make
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Model> Models {get; set;}

        public Make() // ctor to initialize the instance of the collection to evoid nullrefexception
        {
            Models = new Collection<Model>();
        }
    }
}