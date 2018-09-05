using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class HotelProduct: IProduct
    {
        public String GetTypeOfProduct()
        {
            return "Hotel";
        }

        public void Save()
        {
            Console.WriteLine("Booking hotel Product");
        }

        public void Book()
        {
            Console.WriteLine("saving hotel product completed");
        }
    }
}
