
using Domain.Table.Enum;
using Domain.Table.ValueObject;

namespace Domain.Table
{
    public class Table
    {
        public int Id { get; private set; }
        public int Number { get; private set; }
        public StatusTable Status { get; private set; }
        public OrderId? OrderId { get; private set; }
        public LockStatus LockStatus { get; private set; }



        public Table()
        {
            Status = StatusTable.Livre;
            LockStatus = LockStatus.Unlocked();
        }



        //Actions
        public void CreateOrder(OrderId idOrder, int idUser)
        {
            EnsureUserHasLock(idUser);
            EnsureNotClosed();
            EnsureNotOccupied();
            SetIdOrder(idOrder);
            Occupy();

        }


        public void CloseOrder()
        {
            EnsureIsOrder();
            EnsureIsLocked();

            if (Status is StatusTable.Livre)
                throw new InvalidOperationException("Mesa já livre.");

            EnsureNotClosed();


            OrderId = null;
            ReleaseTable();

        }

        public void Deleted()
        {
            if (OrderId is not null && Status is StatusTable.Livre)
                throw new InvalidOperationException("Estado inválido: mesa com pedido vinculado, mas consta como disponível.");

            EnsureNotOrder();
        }

        private void SetIdOrder(OrderId idOrder)
        {

            EnsureNotOccupied();
            EnsureNotOrder();

            OrderId = idOrder;
        }

        //-----------------

        //Actions internal
        private void Occupy()
        {
            EnsureNotClosed();
            EnsureNotOccupied();

            Status = StatusTable.Ocupada;
        }

        private void ReleaseTable()
        {
            EnsureNotClosed();
            EnsureNotOrder();

            Status = StatusTable.Livre;
        }

        private void OpenTable()
        {
            if (Status is not StatusTable.Fechada)
                throw new InvalidOperationException("Mesa já não consta como fechada.");

            Status = StatusTable.Livre;
        }

        public void Close()
        {
            EnsureNotOrder();

            Status = StatusTable.Fechada;
        }

        public void LockedAcess(int idUser)
        {
            if (idUser is <= 0)
                throw new ArgumentException("Id inválido.");

            LockStatus = LockStatus.Locked(idUser);
        }

        public void UnlockedAcess(int idUser)
        {
            if (!LockStatus.IsSameUser(idUser))
                throw new InvalidOperationException("Úsuario diferente não pode desbloquear a mesa.");

            LockStatus = LockStatus.Unlocked();
        }

        //-----------------

        //Read to Application
        public bool IsLocked() => LockStatus.StatusIsLock();
        public bool IsOccupied() => Status == StatusTable.Ocupada;
        public bool IsClosed() => Status == StatusTable.Fechada;



        //Ensure
        private void EnsureNotClosed()
        {
            if (Status is StatusTable.Fechada)
                throw new InvalidOperationException("Mesa está fechada.");
        }

        private void EnsureNotOccupied()
        {
            if (Status is StatusTable.Ocupada && OrderId is not null)
                throw new InvalidOperationException("Mesa já está ocupada.");
        }

        private void EnsureNotOrder()
        {
            if (OrderId is not null)
                throw new InvalidOperationException("Pedido vinculado.");
        }

        private void EnsureIsOrder()
        {
            if (OrderId is null)
                throw new InvalidOperationException("Sem pedido vinculado.");
        }

        private void EnsureIsLocked()
        {
            if (!LockStatus.StatusIsLock())
                throw new InvalidOperationException("Mesa precisa estar bloqueada.");
        }

        private void EnsureUserHasLock(int idUser)
        {
            if (!LockStatus.StatusIsLock())
                throw new InvalidOperationException("Mesa não está bloqueada.");

            if (!LockStatus.IsSameUser(idUser))
                throw new InvalidOperationException("Úsuario não possui o bloqueio.");
        }
    }
}