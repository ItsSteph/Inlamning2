using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Pages.Brand
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication3.Data.WebApplication3Context _context;

        public IndexModel(WebApplication3.Data.WebApplication3Context context)
        {
            _context = context;
        }

        public IList<Models.Brand> Brand { get;set; }

        
        public async Task OnGetAsync()
        {
            Brand = await _context.Brand
                .Include(b => b.Manufacture).ToListAsync();

            IQueryable<Models.Brand> brandIQ = from b in _context.Brand select b;

            //Connection between brand and manufacture makes it possible to read related data in manufacture and display it in brand.
            Brand = await brandIQ
                .Include(b => b.Manufacture)
                .ToListAsync();
        }
    }
}
