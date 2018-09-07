using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class CarProduct: IProduct
    {
        public string prodtype = "CarProduct";
        public string prodname = "B.M.W";
        public bool isbooked = false;
        public int price = 500;
        public string ProductType { get { return prodtype; } set { prodtype = value; } }
        public string ProductName { get { return prodname; } set { prodname = value; } }
        public bool IsBooked { get { return isbooked; } set { isbooked = value; } }
        public int fareprice { get { return price; } set { price = value; } }


    }
}
