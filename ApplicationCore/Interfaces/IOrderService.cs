using ApplicationCore.DTOs;

namespace ApplicationCore.Services.Interfaces
{
    public interface IOrderService
    {
        uint Add();

        bool Edit();

        OrderDTO Get();

        bool Delete();
    }
}
