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
    public class MerchandiseModel : PageModel
    {
        private readonly APSContext _context;

        public MerchandiseModel(APSContext context)
        {
            _context = context;
        }

        public IList<Merchandise> Merchandise { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Merchandises != null)
            {
                Merchandise = await _context.Merchandises.ToListAsync();
            }
        }
    }
}
