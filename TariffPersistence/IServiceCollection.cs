using Microsoft.Extensions.DependencyInjection;
using TariffPersistence.Model;
using TariffPersistence.Model.Interface;

namespace TariffPersistence
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddTariffsDependency(this IServiceCollection services)
        {

            services.AddScoped<ITariff, BasicTariff>();
            services.AddScoped<ITariff, PackagedTariff>();
            return services;
        }
    }
}
