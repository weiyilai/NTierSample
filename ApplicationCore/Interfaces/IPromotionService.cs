using ApplicationCore.DTOs;

namespace ApplicationCore.Services.Interfaces
{
    public interface IPromotionService
    {
        uint Add();

        bool Edit();

        PromotionDTO Get();

        bool Delete();
    }
}
