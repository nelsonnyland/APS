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
    public class LocationsModel : PageModel
    {
        private readonly APSContext _context;

        public LocationsModel(APSContext context)
        {
            _context = context;
        }

        public IList<Locsite> Locations { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Locsites != null)
            {
                Locations = await _context.Locsites.ToListAsync();
            }
        }
    }
}
