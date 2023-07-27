using ApplicationCore.Services;
using ApplicationCore.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationCore;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationService(
        this IServiceCollection services
        )
    {
        services.AddTransient<IAccountService, AccountService>()
            ;

        return services;
    }
}