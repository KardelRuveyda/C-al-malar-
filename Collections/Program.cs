using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList();

            List<string> cities = new List<string>();
            cities.Add("Ankara");

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { FirstName = "Kardel", Id = 5 });
            customers.Add(new Customer { FirstName = "Orhan", Id = 3 });


            List<Customer> customers2 = new List<Customer>
            {
               new Customer{Id=2, FirstName="Kardel"},
               new Customer{Id=3, FirstName="Orhan"}
            };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);

            }


            Console.ReadLine();
        }

        private static void ArrayList()
        {
            ArrayList citiesList = new ArrayList();

            citiesList.Add("Ankara");
            citiesList.Add("İstanbul");



            citiesList.Add("Adana");

            foreach (var item in citiesList)
            {
                Console.WriteLine(item);
            }
        }



    }


    class Customer
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
    }
}
