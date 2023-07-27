using ApplicationCore.DTOs;
using ApplicationCore.Services.Interfaces;

namespace ApplicationCore.Services
{
    public class ProductService : IProductService
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

        public ProductDTO Get()
        {
            return new ProductDTO();
        }
    }
}
