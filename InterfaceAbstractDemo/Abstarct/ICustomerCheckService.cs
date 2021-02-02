using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstarct
{
    public interface ICustomerCheckService
    {
         bool CheckIfRealPerson(Customer customer);
    }
}
