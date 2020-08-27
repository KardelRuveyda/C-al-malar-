using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "Trazon", "İzmir");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName="Kardel" }, new Customer{FirstName="Orhan" });

            foreach (var item in result2)
            {
                Console.WriteLine(item);    
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
    }

    interface IRepository<T> where T:class,IEntity,new()
    {

    }

    class Student
    {

    }

 
}
