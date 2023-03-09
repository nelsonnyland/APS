using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using APS.Context;
using APS.Models;

namespace APS.Pages.Views
{
    public class VendorsModel : PageModel
    {
        private readonly APSContext _context;

        public VendorsModel(APSContext context)
        {
            _context = context;
        }

        public IList<Vendor> Vendor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Vendors != null)
            {
                Vendor = await _context.Vendors.ToListAsync();
            }
        }
    }
}
