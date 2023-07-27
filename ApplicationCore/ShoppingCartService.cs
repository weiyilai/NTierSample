using ApplicationCore.DTOs;
using ApplicationCore.Services.Interfaces;

namespace ApplicationCore.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        public uint Add()
        {
            return 0u;
        }

        public bool Delete()
        {
            return true;
        }

        public bool Edit()
        {
            return true;
        }

        public ShoppingCartDTO Get()
        {
            return new ShoppingCartDTO();
        }
    }
}
