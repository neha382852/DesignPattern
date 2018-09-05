using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class AirProduct: IProduct
    {
        public String GetTypeOfProduct()
        {
            return "Air";
        }

        public void Save()
        {
            Console.WriteLine("Booking Air Product");
        }

        public void Book()
        {
            Console.WriteLine("saving air product completed");
        }
    }
}
