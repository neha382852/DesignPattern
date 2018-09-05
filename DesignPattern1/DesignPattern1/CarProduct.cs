using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class CarProduct: IProduct
    {
        public String GetTypeOfProduct()
        {
            return "Car";
        }

        public void Save()
        {
            Console.WriteLine("Booking Car Product");
        }

        public void Book()
        {
            Console.WriteLine("saving car product completed");
        }
    }
}
