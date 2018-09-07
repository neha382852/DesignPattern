using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPattern1
{

        public class Logger
        {

        string path = @"C:\Users\nanand\Desktop\DesignPattern\LogFile.txt";
        private Logger() { }
        private static Logger _instance;
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        public void AppendToLogFile(string message)
        {
            using (StreamWriter streamwriter = File.AppendText(path))
            {
                streamwriter.WriteLine(message+ '\n');
                streamwriter.WriteLine();

            }
        }
       

        }
    }



