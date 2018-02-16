namespace proyecto_prueba.Entities
{
    public class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int StockMinimo {get;set;}

        public override string ToString()
        {
            return $"{this.ProductId} {this.Name} {this.Stock} {this.StockMinimo}";
        }
    }
}