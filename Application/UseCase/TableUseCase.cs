using Domain.Table;

namespace Application.UseCase
{
    public class TableUseCase(ITableRepository tableRepository)
    {
        private readonly ITableRepository _tableRepository = tableRepository;


        public async Task LockedAcessUseCase(int idTable, int idUser)
        {

            if (idTable is <= 0 || idUser is <= 0) throw new ArgumentException("Id Menor ou igual á zero inválido.");

            var table = await _tableRepository.GetByIdAsync(idTable)
                ?? throw new Exception("Mesa não encontrada. ");

            table.LockedAcess(idUser);

            await _tableRepository.SaveChangesAsync();

        }

        public async Task UnlockedAcessUseCase(int idTable, int idUser)
        {
            if (idTable is <= 0 || idUser is <= 0) throw new ArgumentException("Id Menor ou igual á zero inválido.");

            var table = await _tableRepository.GetByIdAsync(idTable)
               ?? throw new Exception("Mesa não encontrada. ");

            table.UnlockedAcess(idUser);

            await _tableRepository.SaveChangesAsync();

        }

        public async Task CreateOrderUseCase ()
        {
            
        }

        public async Task CloseTableUseCase (int idTable)
        {
            if (idTable is <= 0) throw new ArgumentException("Id inválido. Menor ou igual a zero.");

            var table = await _tableRepository.GetByIdAsync(idTable)
                ?? throw new Exception("Mesa não encontrada.");

            table.Close();

            await _tableRepository.SaveChangesAsync();

        }
    }
}