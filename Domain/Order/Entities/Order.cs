using Domain.Order.Entities;
using Domain.Order.Enum;

namespace Domain.Order.Entity
{
    public class Order
    {
        public int Id { get; private set; }
        public int TableId { get; private set; }
        public decimal TotalOrder { get; private set; }
        public Status Status { get; private set; }
        public DateTime TimeCreate { get; private set; }
        private readonly List<Item> _itens = [];
        public IReadOnlyCollection<Item> Itens => _itens;


        public Order(Item item)
        {

            if (item == null)
                throw new ArgumentNullException(nameof(item));

            AddItem(item);


            TimeCreate = DateTime.UtcNow;
            Status = Status.Iniciado;
        }



        //METOS DE LISTA
        public void AddItem(Item item)
        {
            if (item == null)
                throw new ArgumentException(null, nameof(item));

            if (item.Quantity <= 0)
                throw new Exception("Quantidade inválida");

            _itens.Add(item);

        }

        public void RemoveItem (Item item)
        {
            if(item == null) 
                throw new Exception("Sem item.");

            _itens.Remove(item);
        }


       
        
    }
}