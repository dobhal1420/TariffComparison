using TariffComparisonCore.Services.Interface;
using TariffPersistence.Model.Interface;
using TariffPersistence.Helper;

namespace TariffComparisonCore.Services
{
    public class ComparerService : IComparerService
    {
        private IEnumerable<ITariff> _tariffs;
        public ComparerService(IEnumerable<ITariff> tariffs)
        {
            _tariffs = tariffs ?? throw new ArgumentNullException(nameof(tariffs));
        }
        public List<ITariff> Compare(int consumption)
        {

            return _tariffs.OrderBy(x => x.AnnualCost(consumption)).ToList();
        }
    }
}
