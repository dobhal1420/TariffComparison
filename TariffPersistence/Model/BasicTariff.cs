using TariffPersistence.Helper;
using TariffPersistence.Model.Interface;

namespace TariffPersistence.Model
{
    public class BasicTariff : ITariff
    {
        private const int BaseCost = 5;
        private const double ConsumptionCost = 0.22;
        private double annualCost;

        public double AnnualCost(int consumption)
        {
            annualCost = (BaseCost * 12) + (ConsumptionCost * consumption);
            return annualCost;
        }
        public TariffType TariffName { get => TariffType.Basic; }

        public override string ToString()
        {
            return $"{nameof(TariffName)}: {TariffName.ToString()}, {"Annual Cost"}: {annualCost.ToString()}";
        }
    }
}
