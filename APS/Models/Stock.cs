namespace APS.Models
{
    public class Stock
    {
        public int ID { get; set; }
        public int LocID { get; set; }
        public int InvoiceID { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}
