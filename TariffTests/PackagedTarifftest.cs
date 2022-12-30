using TariffPersistence.Model;
using TariffPersistence.Model.Interface;

namespace TariffTests
{
    public class PackagedTariffTests
    {
        private ITariff tarrif;

        [SetUp]
        public void Setup()
        {
            tarrif = new PackagedTariff();
        }

        [Test]
        [TestCase(800, 3500)]
        [TestCase(950, 4500)]
        [TestCase(1400, 6000)]
        public void AnnualCostShouldBeCorrect(int cost, int consumption)
        {

            // Assert
            Assert.That(tarrif.AnnualCost(consumption), Is.EqualTo(cost));
        }
    }
}