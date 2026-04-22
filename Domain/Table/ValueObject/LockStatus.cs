using Domain.Table.Enum;

namespace Domain.Table.ValueObject
{
    public class LockStatus
    {

        public int? IdUser { get; }
        public StatusLock StatusLock { get; }
        public DateTime TimeLock { get; }

        public LockStatus(int? idUser, StatusLock statusLock)
        {
            IdUser = idUser;
            StatusLock = statusLock;
            TimeLock = DateTime.Now.AddMinutes(30);
        }

        public bool HasUserId() => IdUser.HasValue;
        public bool StatusIsLock() => StatusLock == StatusLock.Bloqueado;
        public bool StatusIsUnlocked() => StatusLock == StatusLock.Liberado;
        public bool IsExpired(int minute) => DateTime.UtcNow > TimeLock.AddMinutes(minute);

        public LockStatus Locked(int idUser) => new (idUser, StatusLock.Bloqueado);
        public LockStatus Unlocked() => new (null, StatusLock.Liberado);
        
        



    }
}