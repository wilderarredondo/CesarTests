using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Reports
{
    public class SalesRpt
    {
        public void RptTotalSales(Bills objBills)
        {
            Console.WriteLine("Total Sales Report");
            Console.WriteLine("");
            Console.Write("Total Sales Amount:");
            Console.Write(objBills.BillTotal);
            Console.WriteLine("  ");
            Console.WriteLine("  ");
        }
    }
}