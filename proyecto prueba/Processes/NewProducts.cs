using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Processes
{
    public class NewProducts
    {
        public Products Register()
        {
            Console.WriteLine("Registration of New Products");
            Console.WriteLine("ProductId");
            int ProductId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ProductName");
            string ProductName = Console.ReadLine();

            Console.WriteLine("ProductStock");
            if (!int.TryParse(Console.ReadLine(), out int ProductStock))
            {
                return null;
            }

            Console.WriteLine("ProductStockMinimo");
            if (!int.TryParse(Console.ReadLine(), out int ProductStockMinimo))
            {
                return null;
            }

            Products ProdObj = new Products();
            ProdObj.ProductId = ProductId;
            ProdObj.Name = ProductName;
            ProdObj.Stock = ProductStock;
            ProdObj.StockMinimo = ProductStockMinimo; ;

            return ProdObj;
        }
    }


}