using ApplicationCore.DTOs;
using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace ApplicationCore.Services
{
    public class AccountService : IAccountService
    {
        private readonly ILogger<AccountService> _logger;
        private readonly IAccountRepository _accountRepository;

        public AccountService(
            ILogger<AccountService> logger, 
            IAccountRepository accountRepository
            )
        {
            _logger = logger;
            _accountRepository = accountRepository;
        }

        public async Task<int> Add()
        {
            return await _accountRepository.Create(new Infrastructure.Entities.Account
            {

            });
        }

        public bool Delete()
        {
            return true;
        }

        public bool Edit()
        {
            return true;
        }

        public AccountDTO Get()
        {
            return new AccountDTO();
        }
    }
}
