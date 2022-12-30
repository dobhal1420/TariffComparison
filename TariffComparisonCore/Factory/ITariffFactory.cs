using TariffPersistence.Helper;
using TariffPersistence.Model.Interface;

namespace TariffComparisonCore.Factory
{
    /// <summary>
    /// The Creator Interface Class
    /// </summary>
    public interface ITariffFactory
    {
        public ITariff GetTariff(TariffType tariff);

    }
}
