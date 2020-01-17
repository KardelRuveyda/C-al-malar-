using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer
            {
                ID = 1,
                FirstName = "Kardel",
                LastName = "Cetin",
                Adress ="Bahçelievler/İstanbul"
            });

            //Customer customer = new Customer {
            //    ID = 1,
            //    FirstName = "Orhan",
            //    LastName="Cetin",
            //    Adress="Güngören/İstanbul"
            //};

            //personManager.Add(customer);


            Console.ReadLine();
        }
    }

    //Temel nesne oluşturup ; implement etme işlemi yapılır.Soyut nesnelerdir.Tek başına anlam ifade etmez
    //Sen bu özellikleri tanımladıysan ; implemente edilen classlarad kullanmalısın.
    interface IPerson
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer:IPerson // IPERSON de tanımlanmış herşeyi Customer'da görebilriiz.
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }

    class Student:IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        //paremetre alarak ekleme yapacağım. Parametre olarak bana Müşteri nesnesi ver.
       public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
