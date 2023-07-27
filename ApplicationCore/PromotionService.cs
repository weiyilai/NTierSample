using ApplicationCore.DTOs;
using ApplicationCore.Services.Interfaces;

namespace ApplicationCore.Services
{
    public class PromotionService : IPromotionService
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

        public PromotionDTO Get()
        {
            return new PromotionDTO();
        }
    }
}
