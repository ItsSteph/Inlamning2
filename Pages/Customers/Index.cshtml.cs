using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication3.Data.WebApplication3Context _context;

        public IndexModel(WebApplication3.Data.WebApplication3Context context)
        {
            _context = context;
        }
        

        public string LastNameSort { get; set; }
        public string FirstNameSort { get; set; }
        public string CurrentFilter { get; set; }

        public IList<Models.Customers> Customers { get;set; }

        //Handles sorting and filtering
        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            
            
            LastNameSort = String.IsNullOrEmpty(sortOrder) ? "lastname_desc" : "";
            FirstNameSort = String.IsNullOrEmpty(sortOrder) ? "firstname_desc" : "";

            IQueryable<Models.Customers> customerIQ = from c in _context.Customers select c;

            CurrentFilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                customerIQ = customerIQ.Where(c => c.LastName.Contains(searchString)
                                                   || c.FirstName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "lastname_desc":
                    customerIQ = customerIQ.OrderByDescending(b => b.LastName);
                    break;
                case "firstname_desc":
                    customerIQ = customerIQ.OrderByDescending(b => b.FirstName);
                    break;
                default:
                    customerIQ = customerIQ.OrderBy(c => c.CustomerId);
                    break;
            }

            Customers = await customerIQ.AsNoTracking().ToListAsync();
        }
    }
}
