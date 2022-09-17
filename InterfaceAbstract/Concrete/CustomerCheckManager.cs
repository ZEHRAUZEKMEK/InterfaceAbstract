using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

        
    }
}
