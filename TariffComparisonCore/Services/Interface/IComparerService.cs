using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffPersistence.Model.Interface;

namespace TariffComparisonCore.Services.Interface
{
    public interface IComparerService
    {
        List<ITariff> Compare(int consumption);
    }
}
