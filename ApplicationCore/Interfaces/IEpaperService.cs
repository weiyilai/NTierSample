using ApplicationCore.DTOs;

namespace ApplicationCore.Services.Interfaces
{
    public interface IEpaperService
    {
        uint Add();

        bool Edit();

        EpaperDTO Get();

        bool Delete();
    }
}
