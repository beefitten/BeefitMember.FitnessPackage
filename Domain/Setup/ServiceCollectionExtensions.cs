using Domain.Services.FitnessPackages;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Setup
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services
                .AddTransient<IFitnessPackageService, FitnessPackageService>();

            return services;
        }
    }
}