using ApplicationCore.Services.Interfaces;

namespace ApplicationCore.Services
{
    public class SmsService : ISmsService
    {
        public async Task Send()
        {
            await Task.CompletedTask;
        }
    }
}
