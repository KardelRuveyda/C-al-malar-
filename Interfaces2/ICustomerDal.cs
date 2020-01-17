using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    interface ICustomerDal
    {
        //Dal veri işlerini yapmak için Update/Delete
        //Farklı implemetasyonlarda kullanılır.  
        void Add();

        void Update();

        void Delete();
    }

    class SqlServerCustomer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added.");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted. ");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated. ");
        }
    }

    //
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated.");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
