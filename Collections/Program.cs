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
            List<Customer> customers = new List<Customer>();
            

            customers.Add(new Customer {Id = 1, FirstName = "Kardel"});

            customers.Add(new Customer{Id = 2,FirstName = "Ruveyda"});

            List<Customer> customers2 = new List<Customer>
            {
                new Customer{Id = 1, FirstName = "Orhan"},
                new Customer{Id = 2 , FirstName = "Vildan"}
            };

            var countCustomer = customers2.Count();

            var customers3 = new Customer {Id = 2, FirstName = "Hasan Kemal"};

            var index = customers2.IndexOf(customers3);

            Console.WriteLine("Index: {0}",index);

            customers.Add(customers3);

            //elaman vermek yerine, array bazlı liste ver ben onu ekleyeyim customers iiçerisine.
            //Liste veya array alıyor zaten.
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 1,FirstName = "Deneme"}, 
                new Customer{Id = 3, FirstName = "Ruveyda"}
            });

            
            
            Console.WriteLine(customers);
            Console.ReadLine();
            //Eğer bu şekilde olursa Collection.Customers döner. Firstname, ID belirmek gerekir.
            //foreach (var customer in customers)
            //{
            //     Console.WriteLine(customer);
            //}

            cities.Add("Ankara");

            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            
            Console.ReadLine();
        }

        private static void ArrayList()
        {
            string[] citiess = new string[2] { "Ankara", "İstanbul" };
            //Yeni bir şehir eklemek gerekiyor ?

            citiess = new string[3];
            //Bunu yapınca diğer taraftaki bellekteki array uçmaktadır. 

            //GÜnümüz projelerinde Koleksiyonlar kullanılmaktadır. Arrayler yerine. 

            citiess[1] = "Adana";
            //0,1 yazabilirsin. 2 yazınca patladı.

            //En temel koleksiyon .net 1. versiyon ile hayata girmiş; arraylistler'dir. 

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            cities.Add("Trabzon");
            Console.WriteLine(cities[2]);
        }



    }

    class  Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
