using ApplicationCore.DTOs;

namespace ApplicationCore.Services.Interfaces
{
    public interface IShoppingCartService
    {
        uint Add();

        bool Edit();

        ShoppingCartDTO Get();

        bool Delete();
    }
}
