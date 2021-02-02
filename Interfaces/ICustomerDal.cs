using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }

    class OracelServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracel added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracel Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracel updated");
        }
    }

    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
    }
    class CustomerManager
    {
        public void X(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
