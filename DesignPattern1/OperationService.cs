using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class OperationService
    {
        public void Book(IProduct product, IRepository storage, int price)
        {
            Logger.Instance.AppendToLogFile("----In book method of---"+ product.ProductType);
            product.IsBooked = true;
            Logger.Instance.AppendToLogFile("Calling AddToFile method of " + product.ProductType + "to add the  booking details to file." );
            storage.AddRecord(product, price);
            Console.WriteLine(product.ProductType + "Booked Successfully!");
        }

        public void Save(IProduct product, IRepository storage, int price)
        {
            Logger.Instance.AppendToLogFile("----In Save method of---" + product.ProductType);
            Logger.Instance.AppendToLogFile("Calling AddToFile method of " + product.ProductType + "to save book details to file.");
            storage.AddRecord(product, price);
            Console.WriteLine(product.ProductType + "saved Successfully!");
        }
    }
}
