using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstarct
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : "+customer.FirstName);
        }
    }
}
