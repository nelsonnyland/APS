using APS.Context;
using APS.Models;
using APS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APS.Pages
{
    public class IndexModel : PageModel
    {
        //APSContext _context;

        //public IndexViewModel ViewModel;

        public IndexModel(APSContext context)
        {
            //_context = context;
        }

        public IActionResult OnGet()
        {
            //ViewModel = new IndexViewModel
            //{
            //    Vendor = _context.Vendors.FirstOrDefault()
            //};
            
            return Page();
        }
    }
}