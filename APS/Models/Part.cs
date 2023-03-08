namespace APS.Models
{
    public class Part
    {
        public int ID { get; set; }
        public int VehID { get; set; }
        public int VendorID { get; set; }
        public int StockID { get; set; }
        public string PartName { get; set; }
        public string PartDesc { get; set; }
    }
}
