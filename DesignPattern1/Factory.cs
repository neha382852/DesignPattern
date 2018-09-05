using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class Factory
    {
      public IProduct GetProduct(string description)
        {
            switch(description)
            {
                case "car": return new CarProduct();
                case "air": return new AirProduct();
                case "hotel": return new HotelProduct();
                case "activity": return new Activity();
                default: return new Activity();
            }
        }
    }
}
