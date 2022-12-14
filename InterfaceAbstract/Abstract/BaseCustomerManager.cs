using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to Database:"+customer.FirstName);
        }
    }
}
