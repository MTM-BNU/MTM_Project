using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MTM_Holidays.Data;
using MTM_Holidays.Models;

namespace MTM_Holidays.Pages.Addresses
{
    public class IndexModel : PageModel
    {
        private readonly MTM_Holidays.Data.ApplicationDbContext _context;

        public IndexModel(MTM_Holidays.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Address> Address { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Addresses != null)
            {
                Address = await _context.Addresses.ToListAsync();
            }
        }
    }
}
