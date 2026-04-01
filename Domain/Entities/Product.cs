using Domain.ValueObjects;

namespace api.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public PriceVO Price { get; private set; }
        public bool Available { get; set; }
        public required string Category { get; set; }
        public required string Type { get; set; } 
        public ICollection<Addons>? Addons { get; set; }


        public Product(decimal price)
        {
            var result = PriceVO.CreatePrice(price);

            if (result.IsFailure) 
                throw new ArgumentException(result.Error);
            
            Price = result.Value;
        }

      
        
    }

    
}