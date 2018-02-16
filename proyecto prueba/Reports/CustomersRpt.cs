using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Reports
{
    public class CustomersRpt
    {
        public void SeniorCustomers(Customers objCustomers)
        {
            Console.WriteLine("Report of Customers over 55 age");
            Console.WriteLine("");

            if (objCustomers.CustomerAge>55)
            {
                Console.Write("CustomerId:");
                Console.WriteLine("       ");
                Console.Write("CustomerName:");
                Console.WriteLine("       ");
                Console.Write("CustomerAddress:");
                Console.WriteLine("       ");
                Console.Write("CustomerAge:");
                Console.WriteLine("       ");
                Console.Write("CustomerBirthdate:");
/*
                objCustomers.ForEach(item =>
                {
                    Console.WriteLine(item);
                }
            );
             */

                Console.Write(objCustomers.ToString());
            }
            else
            {
                Console.Write("No data");
            }
        }
    }

}