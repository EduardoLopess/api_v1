

namespace api.Domain.Entities
{
    public class Flavor
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool Available { get; set; }
    }
}