using System;
using System.Linq;
using System.Collections.Generic;
using proyecto_prueba.Entities;
using proyecto_prueba.Processes;
using proyecto_prueba.Reports;

namespace proyecto_prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesRecord objSalesRecord = new SalesRecord();
            NewCustomer objNewCustomer = new NewCustomer();
            NewSellers objNewSeller = new NewSellers();
            NewProducts objNewProduct = new NewProducts();

            //Reports
            SalesRpt objSalesRpt = new SalesRpt();
            CustomersRpt objCustomersRpt = new CustomersRpt();
            ProductsRpt objProductsRpt = new ProductsRpt();

            List<Products> products = new List<Products>();
            Bills BillsObj = new Bills();
            Customers CustomerObj = new Customers();
            Sellers SellersObj = new Sellers();
            Products ProductObj = new Products();

            Products cola = new Products();
            cola.ProductId = 1;
            cola.Name = "Coke";
            cola.Stock = 50;
            products.Add(cola);
            foreach(Products item in products)
            {
                Console.WriteLine(item);
            }

            products.ForEach(item =>
                {
                    Console.WriteLine(item);
                }
            );
            //products.Where
            int num1 =2;
            bool isBetween = num1 >= 5 & num1 <= 10;
            bool isBetween2 = num1.Between(5, 10);
            int a =2;

            BillsObj = objSalesRecord.SalesRecordMetodo();
            CustomerObj = objNewCustomer.NewCustomerMetodo();
            SellersObj = objNewSeller.NewSellersMetodo();
            ProductObj = objNewProduct.NewProductsMetodo();

            objSalesRpt.RptTotalSales(BillsObj);
            objCustomersRpt.SeniorCustomers(CustomerObj);
            objProductsRpt.StockMin(ProductObj);

//            Console.WriteLine(CustomerObj.CustomerBirthdate );

        }
    }
}