using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Processes
{
    public class NewCustomer
    {
        public Customers NewCustomerMetodo()
        {
            Console.WriteLine("CustomerId");
            int sCustomerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("CustomerName");
            string sCustomerName = Console.ReadLine();

            Console.WriteLine("CustomerAddress");
            string sCustomerAddress = Console.ReadLine();

            Console.WriteLine("CustomerAge");
            int sCustomerAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("CustomerBirthdate") ;
            string sCustomerBirthdate1 = Console.ReadLine();
            DateTime sCustomerBirthdate = Convert.ToDateTime(sCustomerBirthdate1);

            Customers CustObj = new Customers();
            CustObj.CustomerId = sCustomerId;
            CustObj.CustomerName = sCustomerName;
            CustObj.CustomerAddress = sCustomerAddress;
            CustObj.CustomerAge = sCustomerAge;
            CustObj.CustomerBirthdate = sCustomerBirthdate;

            return CustObj;
        }

    }
}