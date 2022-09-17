using InterfaceAbstract.Abstract;
using InterfaceAbstract.Adapters;
using InterfaceAbstract.Concrete;
using System;

namespace InterfaceAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1991, 5, 1), FirstName = "Z", LastName = "U", ID = 12135, NationalityID = "45184789654" });
            Console.ReadLine();
        }
        
    }
}
