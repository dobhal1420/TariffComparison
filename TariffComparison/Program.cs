// See https://aka.ms/new-console-template for more information
using TariffComparisonCore.Services;
using TariffComparisonCore.Services.Interface;

int consumption = 3500;
IComparerService comparerService = new ComparerService();

var results = comparerService.Compare(consumption);

foreach (var item in results)
{
    Console.WriteLine(item.ToString());
}
