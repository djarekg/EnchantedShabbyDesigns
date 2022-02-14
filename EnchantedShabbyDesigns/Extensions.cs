using DotNetCore.AspNetCore;
using DotNetCore.EntityFrameworkCore;
using DotNetCore.IoC;
using DotNetCore.Security;
using Esd.Database;
using Esd.Services;
using Microsoft.EntityFrameworkCore;

namespace Esd;

public static class Extensions
{
    public static void AddContext(this IServiceCollection services)
    {
        var connectionString = services.GetConnectionString(nameof(Context));
        services.AddContext<Context>(options => options.UseSqlServer(connectionString));
    }

    public static void AddSecurity(this IServiceCollection services)
    {
        services.AddHashService();
        services.AddJsonWebTokenService(Guid.NewGuid().ToString(), TimeSpan.FromHours(12));
        services.AddAuthenticationJwtBearer();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddClassesMatchingInterfaces(typeof(IUserService).Assembly);
        services.AddClassesMatchingInterfaces(typeof(IUserRepository).Assembly);
    }

    public static void AddSpa(this IServiceCollection services)
    {
        services.AddSpaStaticFiles("ClientApp/dist");
    }

    public static void UseSpa(this IApplicationBuilder application)
    {
        application.UseSpaAngular("ClientApp", "start", "http://localhost:4200");
    }
}
