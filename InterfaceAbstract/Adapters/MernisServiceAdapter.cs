using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference1.KPSPublicSoapClient client = new MernisServiceReference1.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityID, customer.FirstName.ToUpper, customer.LastName.ToUpper, customer.DateOfBirth.Year);


        }
    }
}
