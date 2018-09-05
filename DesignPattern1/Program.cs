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
            string description = Console.ReadLine();
            description = description.ToLower();
            Factory factoryobj = new Factory();
            IProduct productResult = factoryobj.GetProduct(description);
            Console.WriteLine(productResult.GetTypeOfProduct());
            productResult.Save();
            productResult.Book();
            Console.ReadKey();
        }
    }
}
