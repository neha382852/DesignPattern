using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class AirProduct: IProduct
    {
       
        public string prodtype = "AirProduct ";
        public string prodname = "Air Asia";
        public bool isbooked = false;
        public int price = 300;
        public string ProductType { get { return prodtype; } set { prodtype = value; } }
        public string ProductName { get { return prodname; } set { prodname = value; } }
        public bool IsBooked { get { return isbooked; } set { isbooked = value; } }

        public int fareprice { get { return price; } set { price = value; } }



    }
}
