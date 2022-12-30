// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using TariffComparisonCore;
using TariffComparisonCore.Services;
using TariffComparisonCore.Services.Interface;
using TariffPersistence;

int consumption = 3500;

var services = new ServiceCollection();
services.AddTariffsDependency();
services.AddComparerService();

var provider = services.BuildServiceProvider();

var comparerService = provider.GetService<IComparerService>();

var results = comparerService.Compare(consumption);

foreach (var item in results)
{
    Console.WriteLine(item.ToString());
}
