using ApplicationCore.DTOs;
using ApplicationCore.Services.Interfaces;

namespace ApplicationCore.Services
{
    public class EpaperService : IEpaperService
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

        public EpaperDTO Get()
        {
            return new EpaperDTO();
        }
    }
}
