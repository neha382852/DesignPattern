using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class FileRepository:IRepository
    {
        FileStream _fileStream;
        StreamWriter _streamWriter;
        public FileRepository()
        {
            _fileStream = File.OpenWrite("C:\\Users\\nanand\\Desktop\\DesignPattern\\SaveDetails.txt");
            _streamWriter = new StreamWriter(_fileStream);
        }
      
        public void AddRecord(IProduct product, int price)
        {
            Logger.Instance.AppendToLogFile("---In AddRecord() of FileRepository class---");
            Logger.Instance.AppendToLogFile("Adding"+ product.ProductType + "details to the file.");
            StringBuilder formattedMessage = new StringBuilder();
            formattedMessage.AppendLine("Type Of Product: " + product.ProductType);
            formattedMessage.AppendLine("Name Of Product: " + product.ProductName);
            formattedMessage.AppendLine("Price Of Product: " + price);
            formattedMessage.AppendLine("IsBooked: " + product.IsBooked);
            _streamWriter.WriteLine(formattedMessage.ToString());
            _streamWriter.Flush();
        }

    }
}
