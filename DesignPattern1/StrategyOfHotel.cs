using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class StrategyOfHotel : IFareStrategy
    {
        public int FareCalculation(int totalprice)
        {
            Logger.Instance.AppendToLogFile("----In FareCalculation() of StrategyOfHotel Class---- ");
            return (totalprice + 100);
        }
    }
}
