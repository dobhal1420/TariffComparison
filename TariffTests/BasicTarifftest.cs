using TariffPersistence.Model;
using TariffPersistence.Model.Interface;

namespace TariffTests
{
    public class BasicTariffTests
    {
        private ITariff tarrif;

        [SetUp]
        public void Setup()
        {
            tarrif = new BasicTariff();
        }

        [Test]
        [TestCase(830, 3500)]
        [TestCase(1050, 4500)]
        [TestCase(1380, 6000)]
        public void AnnualCostShouldBeCorrect(int cost, int consumption)
        {

            // Assert
            Assert.That(tarrif.AnnualCost(consumption), Is.EqualTo(cost));
        }
    }
}