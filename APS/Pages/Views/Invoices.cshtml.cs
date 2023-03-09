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
    public class InvoicesModel : PageModel
    {
        private readonly APSContext _context;

        public InvoicesModel(APSContext context)
        {
            _context = context;
        }

        public IList<Invoice> Invoices { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Invoices != null)
            {
                Invoices = await _context.Invoices.ToListAsync();
            }
        }
    }
}
