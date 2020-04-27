using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaces+virtulamethod 

            Database database = new Oracle();
            database.Delete();
            database.Add();

            Database database2 = new Oracle();
            database2.Add();
            database2.Delete();

            Database database3 = new PostgreSQL();
            database3.Add();
            database3.Delete();

            Console.ReadLine();
          
            //Delete abstract olarak tanımlandığı için diğer metodlarda ovverride denmiş 
            //Add ise ortak ; o direk geliyor. 
         
         }
    }

    abstract class Database
    {
        //Ekleme heryerde aynı
        //abstract class newlenemiyor
        public void Add()
        {
            Console.WriteLine("Added by default.");
        }
        //Silme farklı
        public abstract void Delete();
    }

    class SqlServer : Database
    {
        //abstract içi dolu olmayan virtual metottur.
        public override void Delete()
        {
            Console.WriteLine("Sql Server deleted by. ");
        }
    }

    class Oracle : Database
    {
        //içi dolu olmayan virtual methoddur
        public override void Delete()
        {
            Console.Write("Oracle Deleted by.");
        }
    }

    class PostgreSQL : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by PostgreSQL");
            Console.ReadLine();
        }
    }

}
