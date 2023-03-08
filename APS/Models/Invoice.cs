namespace APS.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public int VendorID { get; set; }
        public string InvoiceDesc { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceTotal { get; set; }
    }
}
