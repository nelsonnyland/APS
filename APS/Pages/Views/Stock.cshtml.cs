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
    public class StockModel : PageModel
    {
        private readonly APSContext _context;

        public StockModel(APSContext context)
        {
            _context = context;
        }

        public IList<Stock> Stock { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Stocks != null)
            {
                Stock = await _context.Stocks.ToListAsync();
            }
        }
    }
}
