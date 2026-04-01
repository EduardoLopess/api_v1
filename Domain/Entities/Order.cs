
namespace api.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public required Table Table { get; set; } 
        public DateTime CreationData { get; private set;}
        public ICollection<Item> Items { get; set; } = [];
        public decimal TotalOrder { get; set;}
        public bool LockedOrder { get; set; }
        public string? LockedOrderClientIdentification { get; set;}

        public void SetCrationData ()
        {
            CreationData = DateTime.Now;
        }
       
    }
}