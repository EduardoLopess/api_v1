
namespace api.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public required Order Order { get; set; }
        public required Product Product { get; set; }
        public int QtdItem { get; set; }
    }
}