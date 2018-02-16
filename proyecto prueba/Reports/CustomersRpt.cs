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
                Console.Write("       ");
                Console.Write("CustomerName:");
                Console.Write("       ");
                Console.Write("CustomerAddress:");
                Console.Write("       ");
                Console.Write("CustomerAge:");
                Console.Write("       ");
                Console.Write("CustomerBirthdate:");
                Console.WriteLine("");
/*
                objCustomers.ForEach(item =>
                {
                    Console.WriteLine(item);
                }
            );
             */
*/
                Console.Write(objCustomers.ToString());
            }
            else
            {
                Console.Write("No data");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
            }
        }
    }

}