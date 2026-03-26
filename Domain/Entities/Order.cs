
namespace api.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public required Table Table { get; set; } 
        public DateTime CreationData { get; set;}
        public ICollection<Item> Items { get; set; } = [];
        public decimal TotalOrder { get; set;}
        public string? LockedOrder { get; set; }
    }
}