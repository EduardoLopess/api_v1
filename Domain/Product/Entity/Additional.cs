using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Product.ValueObject;

namespace Domain.Product.Entity
{
    public class Additional
    {
        public int Id { get; private set; }
        public string Name { get; private set; } 
        public Price Price { get; private set; }

        public Additional ()
        {
            
        }
    }
}