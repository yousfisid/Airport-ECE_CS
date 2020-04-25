using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JDSY.MyAirport.EF;

namespace JDSY.MyAirportRazor.Pages.Vols
{
    public class IndexModel : PageModel
    {
        private readonly JDSY.MyAirport.EF.MyAirportContext _context;

        public IndexModel(JDSY.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IList<Vol> Vol { get;set; }

        public async Task OnGetAsync()
        {
            Vol = await _context.Vols.ToListAsync();
        }
    }
}
