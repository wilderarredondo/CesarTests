namespace proyecto_prueba.Entities
{
    public class Bills
    {
        public int BillNumber {get;set;}
        public string BillDate {get;set;}
        public string BillTotal {get;set;}

        public override string ToString()
        {
            return $"{this.BillNumber} {this.BillDate} {this.BillTotal}";
        }
    }

}