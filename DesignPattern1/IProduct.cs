using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    interface IProduct
    {
        string ProductType { get; set; }
        string ProductName { get; set; }
        bool IsBooked { get; set; }
        int fareprice { get; set; }
       

    }
}
