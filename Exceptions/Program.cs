using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleException(()=> 
            {

                FindExcept();
            });
            Console.ReadLine();

        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
                //Parametre olarak gönderilen fonksiyonu çalıştır. 
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
             }
        }

        private static void FindExcept()
        {

            List<string> students = new List<string> { "Kardel", "Rüveyda", "Çetin" };

            if (!students.Contains("Orhan"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Bulundu");
            }

            Console.ReadLine();
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Kardel", "Rüveyda", "Çetin" };

                students[3] = "Rabia";

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception!!");
            }

        }

    }

}
