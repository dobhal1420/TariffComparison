using TariffPersistence.Helper;
using TariffPersistence.Model.Interface;

namespace TariffComparisonCore.Factory
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class TariffTypeFactory
    {
        public abstract ITariff GetTariff(TariffType tariff);

    }
}
