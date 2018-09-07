using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class HotelProduct: IProduct
    {
       
        public string prodtype = "HotelProduct ";
        public string prodname = "Hotel Hyatt";
        public bool isbooked = false;
        public int price = 4500;
        public string ProductType { get { return prodtype; } set { prodtype = value; } }
        public string ProductName { get { return prodname; } set { prodname = value; } }
        public bool IsBooked { get { return isbooked; } set { isbooked = value; } }
        public int fareprice { get { return price; } set { price = value; } }



    }
}
