using ApplicationCore.Interfaces.Repository;
using Infrastructure.DbContexts;
using Infrastructure.Entities;

namespace Infrastructure.Repository;

public class AccountRepository : RepositoryBase<Account>, IAccountRepository
{
    public AccountRepository(ApplicationDbContext context) : base(context)
    {
    }
}
