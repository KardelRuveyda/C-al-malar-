using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaceeler instance oluşturmaz. Newlenemez. 
            //Interface ve abstract newlenemez. 

            CustomerManager customerManager = new CustomerManager();

            //Oracle ekleme.
            //customerManager.Add(new OracleCustomerDal()); 
            
            //Sql Server ekleme.
            customerManager.Add(new SqlServerCustomer());

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson // IPERSON de tanımlanmış herşeyi Customer'da görebilriiz.
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
         public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
