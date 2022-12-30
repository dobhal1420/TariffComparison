using TariffComparisonCore.Services.Interface;
using TariffPersistence.Model.Interface;
using System.Linq;
using TariffComparisonCore.Factory;
using TariffPersistence.Helper;

namespace TariffComparisonCore.Services
{
    public class ComparerService : IComparerService
    {
        public List<ITariff> Compare(int consumption)
        {
            var factory = new TariffFactory();
            var result = new List<ITariff>();
            var tariffs = EnumUtil.GetValues<TariffType>();
            foreach (var tariff in tariffs)
            {
                result.Add(factory.GetTariff(tariff));
            }
            return result.OrderBy(x => x.AnnualCost(consumption)).ToList();
        }
    }
}
