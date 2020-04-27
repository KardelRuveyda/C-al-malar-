using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer server = new SqlServer();

            server.Add();
            MySql mySql = new MySql();

            mySql.Add();


            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added.");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            //base.Add denilirse iki add methodu da çalıştırılır. 
            Console.WriteLine("Sql server added by. ");
            base.Add();
        }
    }

    class MySql : Database
    {

    }
}
