using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    interface IFareStrategy
    {
        int FareCalculation(int totalFare);
    }
}
