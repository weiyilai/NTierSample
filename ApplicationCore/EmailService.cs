using ApplicationCore.Services.Interfaces;

namespace ApplicationCore.Services
{
    public class EmailService : IEmailService
    {
        public async Task Send()
        {
            await Task.CompletedTask;
        }
    }
}
