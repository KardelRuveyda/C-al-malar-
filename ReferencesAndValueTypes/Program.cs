using System;
using System.Data;

namespace ReferencesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;

            number2 = number1;
            number1 = 30;

            string[] cities = new string[] { "Ankara", "Aadana" };
            string[] cities2 = new string[] { "Trabzon", "İstanbul" };

            cities2=cities;

            cities[0] = "İstanbul";

            Console.WriteLine(cities2[0]);

            Console.ReadLine();




        }
    }
}
