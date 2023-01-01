using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffPersistence.Model.Interface;
using TariffPersistence.Model;
using Microsoft.Extensions.DependencyInjection;
using TariffPersistence;
using TariffComparisonCore;
using TariffComparisonCore.Services.Interface;

namespace TariffTests
{


    public class Comparertest
    {
        ServiceCollection services = new ServiceCollection();
        IComparerService comparerService;



        [SetUp]
        public void Setup()
        {
            services.AddMockTariffsDependency();
            services.AddComparerService();
            var provider = services.BuildServiceProvider();

            comparerService = provider.GetService<IComparerService>();
        }

        [Test]
        [TestCase(3500)]
        [TestCase(4500)]
        [TestCase(6000)]
        public void TariffsIsSortedAscedingOrderByAnnualCost(int consumption)
        {

            // Act 
            var results = comparerService.Compare(consumption);
            for (int i = 0; i < results.Count - 1; i++)
            {
                // Assert
                Assert.GreaterOrEqual(results[i + 1].AnnualCost(consumption), results[i].AnnualCost(consumption));
            }
            
        }
    }

}
