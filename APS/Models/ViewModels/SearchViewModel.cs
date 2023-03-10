namespace APS.Models.ViewModels
{
    public class SearchViewModel
    {
        public IList<Employee> Employees { get; set; }
        public IList<Invoice> Invoices { get; set; }
        public IList<Locsite> Locations { get; set; }
        public IList<Merchandise> Merchandise { get; set; }
        public IList<Part> Parts { get; set; }
        public IList<Stock> Stock { get; set; }
        public IList<Vehicle> Vehicles { get; set; }
        public IList<Vendor> Vendors { get; set; }
    }
}
