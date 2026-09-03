using Microsoft.Extensions.DependencyInjection;

namespace SkillVault.Modules.Users;

public static class UsersModule
{
    public static IServiceCollection AddUsers(this IServiceCollection services)
    {
        services.AddSingleton<IUserService, UserService>();
        return services;
    }
}