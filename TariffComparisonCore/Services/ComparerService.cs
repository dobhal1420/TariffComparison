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
            var factory = new ConcreteTariffFactory();
            var result = new List<ITariff>();
            result.Add(factory.GetTariff(TariffType.Basic));
            result.Add(factory.GetTariff(TariffType.Packaged));
            return result.OrderBy(x => x.AnnualCost(consumption)).ToList();
        }
    }
}
