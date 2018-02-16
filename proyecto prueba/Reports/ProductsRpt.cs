using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Reports
{
    public class ProductsRpt
    {
        public void StockMin(Products objProducts)
        {
            Console.WriteLine("Report ");
            Console.WriteLine("");

            if (objProducts.StockMinimo < objProducts.StockMinimo )
            {
                Console.Write("ProductId:");
                Console.WriteLine("       ");
                Console.Write("ProductName:");
                Console.WriteLine("       ");
                Console.Write("ProductStock:");
                Console.WriteLine("       ");
                Console.Write("ProductStockMinimo:");
/*
                objCustomers.ForEach(item =>
                {
                    Console.WriteLine(item);
                }
            );
             */

                Console.Write(objProducts.ToString());
            }
            else
            {
                Console.Write("No data");
            }
        }
    }

}