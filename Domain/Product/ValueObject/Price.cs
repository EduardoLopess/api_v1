using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Product.ValueObject
{
    public class Price
    {
        public decimal Value { get; }

        public Price (decimal value)
        {
            if (value <= 0) 
                throw new ArgumentException("Preço inválido.");
        }
    }
}