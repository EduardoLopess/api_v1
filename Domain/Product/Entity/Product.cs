using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Product.Enum;
using Domain.Product.ValueObject;
using Domain.ValueObjects;

namespace Domain.Product.Entity
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public Price Price { get; private set; }
        public bool Availability { get; private set; }
        public Category Category { get; private set; }
        public TypeProduct? TypeProduct { get; private set; }
        public int? CodeNCM { get; private set; }

        public readonly List<Flavor> _flavors = [];
        public IReadOnlyCollection<Flavor>? Flavors => _flavors;

        public readonly List<Additional>? _additionals = [];
        public IReadOnlyCollection<Additional>? Additionals => _additionals;


        public Product(IEnumerable<Flavor>? flavors = null, IEnumerable<Additional>? additionals = null)
        {
            if (flavors != null)
            {
                foreach (var flavor in flavors)
                    AddFlavor(flavor);
            }

            if (additionals != null)
            {
                foreach (var additional in additionals)
                    AddAdditional(additional);
            }
        }






        public bool IsAvailability()
        {
            return Availability;
        }


        public void AddFlavor(Flavor flavor)
        {
            if (flavor == null)
                throw new Exception("Sem sabor.");

            _flavors.Add(flavor);

        }

        public void AddAdditional(Additional additional)
        {
            if (additional == null)
                throw new Exception("Sem adicional. ");

            _additionals.Add(additional);
        }

    }
}