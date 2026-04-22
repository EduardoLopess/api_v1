using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Table.Enum;
using Domain.Table.ValueObject;

namespace Domain.Table.Entity
{
    public class Table
    {
        public int Id { get; private set; }
        public int Number { get; private set; }
        public StatusTable Status { get; private set; }
        public int? IdOrder { get; private set; }
        public LockStatus LockStatus { get; private set; }



        public Table()
        {
            Status = StatusTable.Livre;



        }


        public void CreateOrder(int idOrder)
        {
            if (idOrder <= 0)
                throw new ArgumentException("Id inválido.");

            EnsureNotLocked();
            EnsureNotClosed();
            EnsureNotOccupied();


            SetIdOrder(idOrder);
            Occupy();

        }



        public void CloseOrder()
        {
            EnsureIsOrder();

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

            EnsureNotOrder();
        }

        private void SetIdOrder(int idOrder)
        {
            if (idOrder <= 0)
                throw new ArgumentException("Id inválido. ");

            EnsureNotOccupied();
            EnsureNotOrder();

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
            EnsureNotClosed();

            EnsureNotOrder();

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
            EnsureNotOrder();

            Status = StatusTable.Fechada;
        }

        public void LockedAcess(int idUser)
        {
            if (idUser <= 0)
                throw new ArgumentException("Id inválido.");

            LockStatus.Locked(idUser);
        }

        public void UnlockedAccess()
        {
            LockStatus.Unlocked();
        }

        //Controle de acesso 1 usuario por vez
        private void Locked()
        {

        }

        private void Unlocked()
        {

        }

        private void RenewBlock()
        {

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
                throw new InvalidOperationException("Pedido vinculado.");
        }



        private void EnsureIsOrder()
        {
            if (!IdOrder.HasValue)
                throw new InvalidOperationException("Sem pedido vinculado.");
        }


        private void EnsureNotLocked()
        {
            if (LockStatus.StatusIsLock())
                throw new InvalidOperationException();
        }



    }
}