﻿using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
       private ICustomerCheckService _customerCheckService;
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }
    }
}
