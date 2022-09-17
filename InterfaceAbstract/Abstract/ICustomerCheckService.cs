using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Abstract
{
    public interface ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer);
    }
}
