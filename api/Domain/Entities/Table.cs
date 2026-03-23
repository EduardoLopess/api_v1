
namespace api.Domain.Entities
{
    public class Table
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public bool Available { get; set;}
        public Order? Order { get; set; }
    }
}