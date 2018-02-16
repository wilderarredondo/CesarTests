using System;

namespace proyecto_prueba.Entities
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerAge { get; set; }
        public DateTime CustomerBirthdate { get; set; }

        public override string ToString()
        {
            return $"{this.CustomerId} {this.CustomerName} {this.CustomerAddress} {this.CustomerAge} {this.CustomerBirthdate}";
        }
    }
}