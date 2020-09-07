using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortislem = new DortIslem(2, 3);
            //Console.WriteLine(dortislem.Topla(2, 3));
            //Console.WriteLine(dortislem.Topla2());

            var tip = typeof(DortIslem);

            //DortIslem dortIslem=(DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            //method çalıştırılması.
            var instance = Activator.CreateInstance(tip, 6, 7);

            //GetMethod ile ulaş
            //Invoke ile çalıştır. 
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance, null));


            //sınıfın özelliklerine,attributelerine ulaşmak. 

            //Metodlarına ulaşmak için.
            var metodlar = tip.GetMethods();

            foreach (var item in metodlar)
            {
                Console.WriteLine("Method Adı : {0}", item);

                foreach (var parameterInfo in item.GetParameters())
                {
                    Console.WriteLine("Parametre Adı : {0}", parameterInfo.Name); 
                }

                foreach (var attributeInfo in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Adı : {0}", attributeInfo.GetType().Name);
                }
            }

            Console.ReadLine();

        }

    }

    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }


    }
}
