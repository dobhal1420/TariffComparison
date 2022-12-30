using TariffPersistence.Helper;
using TariffPersistence.Model.Interface;

namespace TariffPersistence.Model
{
    public class PackagedTariff : ITariff
    {
        private const int TopKwhPerYear = 4000;
        private const int DefaultConsumption = 800;
        private const double ConsumptionCost = 0.30;
        private double annualCost;

        public TariffType TariffName { get => TariffType.Packaged; }

        public double AnnualCost(int consumption)
        {
            annualCost = consumption > TopKwhPerYear ?
                                (consumption - TopKwhPerYear) * ConsumptionCost + DefaultConsumption
                                : DefaultConsumption;
            return annualCost;
        }
        public override string ToString()
        {
            return $"{nameof(TariffName)}: {TariffName}, {"Annual Cost"}: {annualCost}";
        }
    }
}
