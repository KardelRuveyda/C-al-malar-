using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    //Void olan ve parametre almayan işlem için delegelik yapıyor.
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();


            //Elçi 
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;

            //operasyonu geri almak için -= kullanlır

            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;

            myDelegate2 += customerManager.ShowAlert2;

            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Thread.Sleep(5000);
            Func<int> getRandomNumber2 = () => new Random().Next(1,100);
            //Console.WriteLine(Topla(2, 3));

            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber2());
            Console.ReadLine();
        }

        static int Topla(int x , int y)
        {
            return x + y;
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful! ");
        }

        public void SendMessage2(string Message)
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert2(string Message)
        {
            Console.WriteLine("Be Careful! ");
        }
    }
}
