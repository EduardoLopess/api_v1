using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Price
    {
        public decimal Value { get; private set;}

        public Price(decimal value)
        {
            if(value < 0) 
                throw new ArgumentException("Preção Inválido.");

            Value = value;
        }
    }
}