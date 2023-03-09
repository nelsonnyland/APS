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
    public class PartsModel : PageModel
    {
        private readonly APSContext _context;

        public PartsModel(APSContext context)
        {
            _context = context;
        }

        public IList<Part> Parts { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Parts != null)
            {
                Parts = await _context.Parts.ToListAsync();
            }
        }
    }
}
