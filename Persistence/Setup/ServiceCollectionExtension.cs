using Microsoft.Extensions.DependencyInjection;
using Persistence.Repository.FitnessPackage;
using Persistence.Settings;

namespace Persistence.Setup
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services
                .AddTransient<IFitnessPackageRepository, FitnessPackageRepository>()
                .AddTransient<IDatabaseSettings, FitnessPackageSettings>();

            return services;
        }
    }
}