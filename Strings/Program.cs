using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            string city2 = "Trabzon";

            string sentence = "My name is Kardel";

            var result = sentence.Length;
            var result2 = sentence.Clone();

            sentence = "My name is Kardel";

            bool result3 = sentence.EndsWith("ğ");

            bool result4 = sentence.StartsWith("M");

            var result5 = sentence.IndexOf("name");

            var result6 = sentence.LastIndexOf("is");

            var result7 = sentence.Insert(0, "Hello: ");

            var result8 = sentence.Substring(1, 3) + ".";
            //1. karakterden itibaren 3 tane al ve . koy

            var result9 = sentence.Remove(2, 5);

            //2 den itibaren 5  karakteri kaldır 


            Console.WriteLine(result8);

            foreach (var item in city)
            {
                //Console.WriteLine(item);
            }


            //Console.WriteLine("{0} {1}", city, city2);

            Console.ReadLine();
        }
    }
}
