using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;

namespace proyecto_prueba.Processes
{
    public class NewSellers
    {

        public Sellers Register()
        {
            Console.WriteLine("Registration of New Sellers");
            Console.WriteLine("SellerId");

            if (!int.TryParse(Console.ReadLine(), out int SeleerId))
            {
                return null;
            }

            Console.WriteLine("SellerName");
            string SellerName = Console.ReadLine();

            Console.WriteLine("SellerComision");
            string SellerComision = Console.ReadLine();

            Sellers SellObj = new Sellers();

            SellObj.SellerId = SeleerId;
            SellObj.SellerName = SellerName;
            SellObj.SellerComision = SellerComision;

            return SellObj;
        }

    }


}