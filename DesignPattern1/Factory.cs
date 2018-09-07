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
            Logger.Instance.AppendToLogFile("---In the GetProduct() of Factory class---");
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == description);
            return (IProduct)Activator.CreateInstance(productType);

        }

        public IFareStrategy GetTypeOfItemForFareCalculation(IProduct product)
        {
            Logger.Instance.AppendToLogFile("---In the GetTypeOfItemForFareCalculation() of Factory class---");
            if(product.ProductType == "CarProduct")
            {
                return new StrategyOfCar();
            }
            else if (product.ProductType == "HotelProduct")
            {
                return new StrategyOfHotel();
            }
            else if (product.ProductType == "AirProduct")
            {
                return new StrategyOfAir();
            }
            else
            {
                return new StrategyOfActivity();
            }
        }

        public IRepository GetTypeOfStorage(string storageType)
        {
            Logger.Instance.AppendToLogFile("---In the GetTypeOfStorage() of Factory class---");
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == storageType);
            return (IRepository)Activator.CreateInstance(productType);
        }
    }
}
