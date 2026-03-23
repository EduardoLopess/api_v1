
namespace api.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public  required string Name { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public  required string Category { get; set; }
        public required string Type { get; set; } 
        public ICollection<Addons>? Addons { get; set; }

    }
}