using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Table.Enum;

namespace Domain.Table.Entity
{
    public class Table
    {
        public int Id { get; private set; }
        public int Number { get; private set; }
        public StatusTable Status { get; private set; }
        public int? IdOrder { get; private set; }
        public DateTime? LockedUntil { get; private set; }





        public Table()
        {
            Status = StatusTable.Livre;
            IdOrder = null;
           
        }


        public void CreateOrder(int idOrder)
        {
            if (idOrder <= 0)
                throw new ArgumentException("Id inválido.");

            EsnureNotLocked();
            EnsureNotClosed();
            EnsureNotOccupied();
            

            SetIdOrder(idOrder);
            Occupy();

        }



        public void CloseOrder()
        {
            EnsureOrder();

            if (Status == StatusTable.Livre)
                throw new InvalidOperationException("Mesa já livre.");

            EnsureNotClosed();


            IdOrder = null;
            Release();

        }

        public void EnsureCanBeDeleted()
        {
            if (IdOrder.HasValue && Status == StatusTable.Livre)
                throw new InvalidOperationException("Estado inválido: mesa com pedido vinculado, mas consta como disponível.");

            if (IdOrder.HasValue)
                throw new InvalidOperationException("Mesa com pedido vinculado não poder ser deletada. ");
        }

        private void SetIdOrder(int idOrder)
        {
            if (idOrder <= 0)
                throw new ArgumentException("Id inválido. ");

            if (Status == StatusTable.Ocupada && IdOrder.HasValue)
                throw new InvalidOperationException("Mesa já vinculada a um pedido.");

            IdOrder = idOrder;
        }


        //MESA DISPONIBILIDADE
        private void Occupy()
        {
           EnsureNotClosed();

            if (Status == StatusTable.Ocupada && IdOrder.HasValue)
                throw new InvalidOperationException("Mesa já ocupada. ");

            Status = StatusTable.Ocupada;
        }

        private void Release()
        {
            if (Status == StatusTable.Fechada)
                throw new InvalidOperationException("Mesa fechada não pode ser aberta.");

            if (IdOrder.HasValue)
                throw new InvalidOperationException("Mesa com pedido vinculado.");

            Status = StatusTable.Livre;
        }


        private void Open()
        {
            if (Status != StatusTable.Fechada)
                throw new InvalidOperationException("Mesa já não consta como fechada.");

            Status = StatusTable.Livre;
        }
        private void Close()
        {
            if (IdOrder.HasValue)
                throw new InvalidOperationException("Mesa com pedido não pode ser fechada.");

            Status = StatusTable.Fechada;
        }



        //Ensure

        private void EnsureNotClosed()
        {
            if (Status == StatusTable.Fechada)
                throw new InvalidOperationException("Mesa está fechada.");
        }

        private void EnsureNotOccupied()
        {
            if (Status == StatusTable.Ocupada && IdOrder.HasValue)
                throw new InvalidOperationException("Mesa já está ocupada.");
        }

        private void EnsureNotOrder()
        {
            if (IdOrder.HasValue)
                throw new InvalidOperationException("Pedido já vinculado.");
        }

        private void EsnureNotLocked()
        {
            if (Status == StatusTable.Bloqueada)
                throw new InvalidOperationException("Mesa bloqueada.");
        }

        private void EnsureOrder()
        {
            if (!IdOrder.HasValue)
                throw new InvalidOperationException("Sem pedido vinculado.");
        }




    }
}