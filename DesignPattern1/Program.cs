using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation;
            string storagetype;
            Factory factoryobj = new Factory();
            OperationService operationservice = new OperationService();
            Logger.Instance.AppendToLogFile("----In Main Class---- ");
            Console.WriteLine("Enter one of the following products:- \n  CarProduct    HotelProduct    Activity   AirProduct ");
            Logger.Instance.AppendToLogFile("Reading Input ");
            string description = Console.ReadLine();
            Logger.Instance.AppendToLogFile("Calling Function GetProduct to determine the type of object to be created.");
            IProduct productResult = factoryobj.GetProduct(description);
            Logger.Instance.AppendToLogFile("Calling Function GetTypeOfItemForFareCalculation to determine for which item you want to calculate fare .");
            IFareStrategy ItemTypeForFareCalculation = factoryobj.GetTypeOfItemForFareCalculation(productResult);
            Console.WriteLine("\nEnter the name of the database where You want to save your data.\n  FileRepository \n  SqlRepository");
            storagetype = Console.ReadLine();
            Logger.Instance.AppendToLogFile("Calling Function GetTypeOfStorage to determine where you want to store your data .");
            IRepository storageType = factoryobj.GetTypeOfStorage(storagetype);
            Console.WriteLine("\nEnter one of the following options:- \n Enter 1 : Book \n Enter 2 : Save");
            operation = Int32.Parse(Console.ReadLine());
            Logger.Instance.AppendToLogFile("Determining the operation which is to be performed ");
            switch (operation)
            {
                case 1:
                    {

                        operationservice.Book(productResult, storageType, ItemTypeForFareCalculation.FareCalculation(productResult.fareprice));
                        break;
                    }

                case 2:
                    {
                        operationservice.Save(productResult, storageType, ItemTypeForFareCalculation.FareCalculation(productResult.fareprice));
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
