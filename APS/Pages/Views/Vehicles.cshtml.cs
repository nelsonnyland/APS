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
    public class VehiclesModel : PageModel
    {
        private readonly APSContext _context;

        public VehiclesModel(APSContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicles { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Vehicles != null)
            {
                Vehicles = await _context.Vehicles.ToListAsync();
            }
        }
    }
}
