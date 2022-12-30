using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffPersistence.Helper;

namespace TariffPersistence.Model.Interface
{
    public interface ITariff
    {
        public TariffType TariffName { get; }

        public double AnnualCost(int consumption);
    }
}
