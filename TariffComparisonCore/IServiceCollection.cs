using Microsoft.Extensions.DependencyInjection;
using TariffComparisonCore.Services.Interface;
using TariffComparisonCore.Services;

namespace TariffComparisonCore
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddComparerService(this IServiceCollection services)
        {
            services.AddScoped<IComparerService, ComparerService>();
            
            return services;
        }
    }
}
