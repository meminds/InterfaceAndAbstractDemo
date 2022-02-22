using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAndAbstractDemo.Entity;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Adapter;

namespace InterfaceAndAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1998,11,29), FirstName = "", LastName = "", NationalityId = "" });
            Console.ReadLine();
        }
    }
}

