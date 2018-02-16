using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Processes
{
    public class SalesRecord
    {
        public Bills Register()
        {
            Console.WriteLine("Registration of New Sales");
            Console.WriteLine("BillNumber");
            if (!int.TryParse(Console.ReadLine(), out int Number))
            {
                return null;
            }

            Console.WriteLine("BillDate");
            string Fecha = Console.ReadLine();

            Console.WriteLine("BillTotal");
            string Total = Console.ReadLine();

            Bills obj = new Bills();
            obj.BillNumber =Number;
            obj.BillDate = Fecha;
            obj.BillTotal = Total;

            return obj;

        }

    }

}
