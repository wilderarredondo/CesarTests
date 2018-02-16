using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Processes
{
    public class NewProducts
    {
        public Products NewProductsMetodo()
        {
            Console.WriteLine("Registration of New Products");
            Console.WriteLine("ProductId");
            int sProductId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ProductName");
            string sProductName = Console.ReadLine();

            Console.WriteLine("ProductStock");
            int sProductStock = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ProductStockMinimo");
            int sProductStockMinimo = Convert.ToInt32(Console.ReadLine());

            Products ProdObj = new Products();
            ProdObj.ProductId = sProductId;
            ProdObj.Name = sProductName;
            ProdObj.Stock = sProductStock;
            ProdObj.StockMinimo = sProductStockMinimo; ;

            return ProdObj;
        }
    }


}