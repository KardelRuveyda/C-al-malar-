using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int id { get; set; } //Sadece tanımlandığı sınıf içerisinde kullanılabilir.s
        protected int ID { get; set; }
        //Protected : Tanımlanan değişken ; Inherit edilen sınıflarda kullanılabilr


    }

    class Student:Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
            //ID Protected çağrıldı.


            //private ise çağıramam.
        }
    }


}
