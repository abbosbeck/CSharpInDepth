using Application.Abstractions;
using Application.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDependencies(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddScoped<IJWTProvider, JwtProvider>();
            
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(Application.AssemblyReference).Assembly);
            });

            return services;
        }
    }
}
