using TariffPersistence.Helper;
using TariffPersistence.Model;
using TariffPersistence.Model.Interface;

namespace TariffComparisonCore.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class TariffFactory : ITariffFactory
    {
        public ITariff GetTariff(TariffType tariff)
        {
            switch (tariff)
            {
                case TariffType.Basic:
                    return new BasicTariff();
                case TariffType.Packaged:
                    return new PackagedTariff();
                default:
                    throw new ApplicationException(string.Format("Tariff '{0}' cannot be created", tariff));

            }
        }

    }

}