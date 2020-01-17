using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interface3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array içerisine iki tane değişken atıldı.
            //Şirketteki tüm veri tabanlarına aynı datayı aktarmak. Customer dal gezildi Add çağrıldı.
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySQLCustomerDal()              
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                
            }

            Console.ReadLine();
        }
    }
}
