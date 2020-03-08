using System;
using System.Data;

namespace ReferencesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 30;
            int number2 = 20;

            number2 = number1;

            Console.WriteLine(number2);
            Console.ReadLine();

            string[] cities1 = new string[] { "Ankara", "Adana", "İstanbul" };
            string[] cities2 = new string[] { "Bursa", "Bolus", "Balıkesir" };

            cities2 = cities1;

            cities1[0] = "İstanbul";

            Console.WriteLine(cities2[0]);

            Console.ReadLine();

            DataTable dataTable;

            DataTable dataTable1 = new DataTable();

            dataTable = dataTable1;



        }
    }
}
