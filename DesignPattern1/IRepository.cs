using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    interface IRepository
    {
        void AddRecord(IProduct product, int fare);
    }
}
