using APS.Context;
using APS.Models;
using APS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace APS.Pages.Views
{
    public class SearchModel : PageModel
    {
        private readonly APSContext _context;
        
        public SearchModel(APSContext context)
        {
            _context = context;
        }

        public string CurrentFilter { get; set; }

        public SearchViewModel SearchVM { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                CurrentFilter = searchString.Trim().ToLower();
            }

            await PullInData();

            Search();
        }

        private async Task PullInData()
        {
            if (_context != null)
            {
                SearchVM = new SearchViewModel();
                SearchVM.Employees = await _context.Employees.ToListAsync();
                SearchVM.Invoices = await _context.Invoices.ToListAsync();
                SearchVM.Locations = await _context.Locsites.ToListAsync();
                SearchVM.Merchandise = await _context.Merchandises.ToListAsync();
                SearchVM.Parts = await _context.Parts.ToListAsync();
                SearchVM.Stock = await _context.Stocks.ToListAsync();
                SearchVM.Vehicles = await _context.Vehicles.ToListAsync();
                SearchVM.Vendors = await _context.Vendors.ToListAsync();
            }
        }

        private void Search()
        {
            if (!string.IsNullOrEmpty(CurrentFilter))
            {
                SearchVM.Employees = SearchEmployees();
                SearchVM.Invoices = SearchInvoices();
                SearchVM.Locations = SearchLocations();
                SearchVM.Merchandise = SearchMerchandise();
                SearchVM.Parts = SearchParts();
                SearchVM.Stock = SearchStock();
                SearchVM.Vehicles = SearchVehicles();
                SearchVM.Vendors = SearchVendors();
            }
        }

        private IList<Employee> SearchEmployees()
        {
            return SearchVM.Employees.Where(e => e.EmpFName.ToLower().Contains(CurrentFilter)
                                              || e.EmpLName.ToLower().Contains(CurrentFilter)
                                              || e.EmpPhone.Contains(CurrentFilter)
                                              || e.EmpStreet.ToLower().Contains(CurrentFilter)
                                              || e.EmpCity.ToLower().Contains(CurrentFilter)
                                              || e.EmpState.ToLower().Contains(CurrentFilter)
                                              || e.EmpCode.Contains(CurrentFilter)
                                            ).ToList();
        }

        private IList<Invoice> SearchInvoices()
        {
            return SearchVM.Invoices.Where(i => i.InvoiceDesc.ToLower().Contains(CurrentFilter)
                                             || i.InvoiceDate.Year.ToString().Contains(CurrentFilter)
                                             || i.InvoiceTotal.ToString().Contains(CurrentFilter)
                                           ).ToList();
        }

        private IList<Locsite> SearchLocations()
        {
            return SearchVM.Locations.Where(l => l.LocName.ToLower().Contains(CurrentFilter)
                                              || l.LocStreet.ToLower().Contains(CurrentFilter)
                                              || l.LocCity.ToLower().Contains(CurrentFilter)
                                              || l.LocState.ToLower().Contains(CurrentFilter)
                                              || l.LocCode.Contains(CurrentFilter)
                                            ).ToList();
        }

        private IList<Merchandise> SearchMerchandise()
        {
            return SearchVM.Merchandise.Where(m => m.MerchName.ToLower().Contains(CurrentFilter)
                                                || m.MerchDesc.ToLower().Contains(CurrentFilter)
                                              ).ToList();
        }

        private IList<Part> SearchParts()
        {
            return SearchVM.Parts.Where(p => p.PartName.ToLower().Contains(CurrentFilter)
                                          || p.PartDesc.ToLower().Contains(CurrentFilter)
                                        ).ToList();
        }

        private IList<Stock> SearchStock()
        {
            return SearchVM.Stock.Where(s => s.Qty.ToString().Contains(CurrentFilter)
                                          || s.Price.ToString().Contains(CurrentFilter)
                                        ).ToList();
        }

        private IList<Vehicle> SearchVehicles()
        {
            return SearchVM.Vehicles.Where(v => v.VehMake.ToLower().Contains(CurrentFilter)
                                            || v.VehModel.ToLower().Contains(CurrentFilter)
                                            || v.VehYear.ToString().Contains(CurrentFilter)
                                            || v.VehEngine.ToLower().Contains(CurrentFilter)
                                          ).ToList();
        }

        private IList<Vendor> SearchVendors()
        {
            return SearchVM.Vendors.Where(v => v.VendorName.ToLower().Contains(CurrentFilter)).ToList();
        }
    }
}
