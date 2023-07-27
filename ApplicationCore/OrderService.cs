using ApplicationCore.DTOs;
using ApplicationCore.Services.Interfaces;

namespace ApplicationCore.Services
{
    public class OrderService : IOrderService
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

        public OrderDTO Get()
        {
            return new OrderDTO();
        }
    }
}
