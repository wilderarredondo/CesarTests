using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Processes
{
    public class NewCustomer
    {
        public Customers Register()
        {
            Console.WriteLine("Registration of New Customer");
            Console.WriteLine("CustomerId");

            if (!int.TryParse(Console.ReadLine(), out int CustomerId))
            {
                return null;
            }

            Console.WriteLine("CustomerName");
            string CustomerName = Console.ReadLine();

            Console.WriteLine("CustomerAddress");
            string CustomerAddress = Console.ReadLine();

            Console.WriteLine("CustomerAge");
            int CustomerAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("CustomerBirthdate") ;

            if (!DateTime.TryParse(Console.ReadLine(), out DateTime CustomerBirthdate))
            {
                return null;
            }

            Customers CustObj = new Customers();
            CustObj.CustomerId = CustomerId;
            CustObj.CustomerName = CustomerName;
            CustObj.CustomerAddress = CustomerAddress;
            CustObj.CustomerAge = CustomerAge;
            CustObj.CustomerBirthdate = CustomerBirthdate;

            return CustObj;
        }

    }
}