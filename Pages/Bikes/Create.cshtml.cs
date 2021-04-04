using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Pages.Bikes
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication3.Data.WebApplication3Context _context;

        public CreateModel(WebApplication3.Data.WebApplication3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Bikes Bikes { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bikes.Add(Bikes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
