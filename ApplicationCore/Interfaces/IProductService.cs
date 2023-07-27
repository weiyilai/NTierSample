using ApplicationCore.DTOs;

namespace ApplicationCore.Services.Interfaces
{
    public interface IProductService
    {
        uint Add();

        bool Edit();

        ProductDTO Get();

        bool Delete();
    }
}
