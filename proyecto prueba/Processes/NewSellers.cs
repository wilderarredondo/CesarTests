using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Processes
{
    public class NewSellers
    {

        public Sellers NewSellersMetodo()
        {
            Console.WriteLine("SellerId");
            int sSeleerId = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("SellerName");
            string sSellerName = Console.ReadLine();

            Console.WriteLine("SellerComision");
            string sSellerComision = Console.ReadLine();

            Sellers SellObj = new Sellers();

            SellObj.SellerId = sSeleerId;
            SellObj.SellerName = sSellerName;
            SellObj.SellerComision = sSellerComision;

            return SellObj;
        }

    }


}