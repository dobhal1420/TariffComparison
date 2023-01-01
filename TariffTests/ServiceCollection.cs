using Microsoft.Extensions.DependencyInjection;
using TariffPersistence.Model.Interface;
using TariffTests.MockTariffs;

namespace TariffTests
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddMockTariffsDependency(this IServiceCollection services)
        {

            services.AddScoped<ITariff, BasicMockTariff>();
            services.AddScoped<ITariff, PackagedMockTariff>();
            return services;
        }
    }
}
