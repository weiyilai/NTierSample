using ApplicationCore.DTOs;

namespace ApplicationCore.Services.Interfaces
{
    public interface IAccountService
    {
        Task<int> Add();

        bool Edit();

        AccountDTO Get();

        bool Delete();
    }
}
