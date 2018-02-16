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
            Console.WriteLine("Minimum Stock Report");
            Console.WriteLine("");

            if (objProducts.StockMinimo < objProducts.StockMinimo )
            {

                Console.WriteLine("       ");
                Console.Write("ProductId:");
                Console.Write("       ");
                Console.Write("ProductName:");
                Console.Write("       ");
                Console.Write("ProductStock:");
                Console.Write("       ");
                Console.Write("ProductStockMinimo:");
                Console.WriteLine("       ");
               /* Console.WriteLine("       ");
                Console.Write(objProducts.ProductId);
                Console.Write("       ");
                Console.Write(objProducts.Name);
                Console.Write("       ");
                Console.Write(objProducts.Stock);
                Console.Write("       ");
                Console.Write(objProducts.StockMinimo);
*/

                Console.Write(objProducts.ToString());
                Console.WriteLine("       ");
            }
            else
            {
                Console.Write("No data");
                Console.WriteLine("       ");
                Console.WriteLine("       ");
                Console.WriteLine("       ");
            }
        }
    }

}