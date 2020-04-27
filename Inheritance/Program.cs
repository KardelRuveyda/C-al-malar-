using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        //Interface inheritance yapısını kullanır
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Kardel" },
                new Student{FirstName="Demirog"},
                new Person{FirstName="Salih"}
            };


            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }



    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //Bir kişinin bir tane babası olur.
    //Customer aslında Person'dan meydana gelmiştir. 
    //Kendine has özellikleri de olabilir 

   //Interface ve Inheritance ?
    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student:Person
    {
        public string Department { get; set; }
    }


}
