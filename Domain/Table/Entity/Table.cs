using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Table.Entity
{
    public class Table
    {
        public int Id { get; private set; }
        public int Number { get; private set; }
        public bool Availability { get; private set; }
        public int? IdOrder { get; private set; }




        public Table ()
        {
            Availability = true;
        }



        //USAR DIRETO A PROP
        public bool IsAvailability()
        {
            return Availability;
        }

        public void EnsureCanBeDeleted()
        {
            if (IdOrder.HasValue && Availability)
                throw new Exception("Estado inválido: mesa com pedido vinculado, mas consta como disponível.");

            if (IdOrder.HasValue)
                throw new Exception("Mesa com pedido vinculado não poder ser deletada. ");
        }

        public void AlterAvailability ()
        {
            Availability = !Availability;
        }

        public void SetIdOrder (int idOrder)
        {
            if(idOrder <= 0)
                throw new ArgumentException("Id inválido. ");

            IdOrder = idOrder;
        }
    }
}