using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Domain.Entities
{
    public class Addons
    {
        public int Id { get; set; }
        public ICollection<Flavor>? Flavors { get; set;}
        public ICollection<Additional>? Additionals { get; set;}
    }
}