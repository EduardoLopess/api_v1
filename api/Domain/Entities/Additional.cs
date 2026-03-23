using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Domain.Entities
{
    public class Additional
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set;}
        public bool Available { get; set; }
    }
}