using APS.Context;
using APS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APS.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(APSContext context)
        {

        }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}