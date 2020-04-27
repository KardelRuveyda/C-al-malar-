using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatabaseLogger databaseLogger = new DatabaseLogger(); //Yanlış  


            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new SmsLogger();
            customerManager.logger = new FileLogger();
            customerManager.logger = new DatabaseLogger();


            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger logger { get; set; }
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Customer Added.");
   
            //Loglama işlemi yapılmak isteniyor. Hangi kullanıcı tarafından eklendi ? 

        }
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!.");
        }
    }

    class FileLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logged!.");
        }
    }

    class SmsLogger: ILogger
    {
        public void Log ()
        {
            Console.WriteLine("Sms logged.");
        }
    }


    interface ILogger
    {
        void Log();
    }
}
