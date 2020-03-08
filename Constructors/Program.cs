using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager(10);
            customer.List();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        //Constructor oluşturmak için ctor (iki kere tab ) 

        private int _count;

        //bana integer bir sayı ver
        public CustomerManager(int count)
        {
            _count = count;
        }
        
        public void List()
        {
            Console.WriteLine("Listed! {0} items ",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }

    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger: ILogger
    {
       public void Log()
        {
            Console.Writeline("Logged the database;");
        }
    }
}
