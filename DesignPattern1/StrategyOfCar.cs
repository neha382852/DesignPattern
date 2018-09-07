using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class StrategyOfCar: IFareStrategy
    {
        public int FareCalculation(int totalprice)
        {
            Logger.Instance.AppendToLogFile("----In FareCalculation() of StrategyOfCar Class---- ");
            return (totalprice + 250);
        }
    }
}
