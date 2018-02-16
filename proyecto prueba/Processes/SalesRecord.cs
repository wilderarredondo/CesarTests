using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Processes
{
    public class SalesRecord
    {
        public Bills SalesRecordMetodo()
        {
            //string sNumber ="";
            Console.WriteLine("BillNumber");
            string bNumber = Console.ReadLine();

            Console.WriteLine("BillDate");
            string bDate = Console.ReadLine();

            Console.WriteLine("BillTotal");
            string bTotal = Console.ReadLine();

            //List<List<string>> Lista = new List<List<string>>();

            Bills obj = new Bills();
            obj.BillNumber =Convert.ToInt32(bNumber);
            obj.BillDate = bDate;
            obj.BillTotal = bTotal;

            //BillsList.Add(obj);

            return obj;

        }

    }

}
