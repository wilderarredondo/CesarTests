namespace proyecto_prueba.Entities
{
public class Sellers
{
    public int SellerId { get; set; }
    public string SellerName { get; set; }
    public string SellerComision { get; set; }

    public override string ToString()
    {
        return $"{this.SellerId} {this.SellerName} {this.SellerComision}";
    }
}

}