using ApplicationCore.Interfaces.Repository;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services
        )
    {
        services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>)).
            AddTransient<IAccountRepository, AccountRepository>()
            ;


        return services;
    }
}