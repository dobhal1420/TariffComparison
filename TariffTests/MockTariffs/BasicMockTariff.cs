using TariffPersistence.Helper;
using TariffPersistence.Model.Interface;

namespace TariffTests.MockTariffs
{
    /// <summary>
    /// Keeping this mock implementation same as real. But this can be any mock. 
    /// </summary>
    public class BasicMockTariff : ITariff
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
            return $"{nameof(TariffName)}: {TariffName}, {"Annual Cost"}: {annualCost}";
        }
    }
}
