using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class Activity: IProduct
    {
        public String GetTypeOfProduct()
        {
            return "Activity";
        }

        public void Save()
        {
            Console.WriteLine("Booking activity Product");
        }

        public void Book()
        {
            Console.WriteLine("saving activity product completed");
        }
    }
}
