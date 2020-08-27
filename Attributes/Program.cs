using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer({

            }
    }
        [ToTable("Customers")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        [AttributeUsage(AttributeTargets.All,AllowMultiple =true)]
        //Hepsine kullanabilirsn. Sadece Class için de belirlenebilirdi.
        class RequiredPropertyAttribute : Attribute
        {

        }

        class ToTableAttribute : Attribute
        {
            private string _tableName;

            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;
            }
        }

        class CustomerDal
        {
            [Obsolete("Don't use Add, instead use AddNew Method ")]
            public void Add(Customer customer)
            {
                Console.WriteLine("Eklendi");
            }

            public void AddNew(Customer customer)
            {
                Console.WriteLine("Eklendi 2 ");
            }
        }
    }
}
