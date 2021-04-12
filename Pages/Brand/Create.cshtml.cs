using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Pages.Brand
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
        ViewData["ManufactureId"] = new SelectList(_context.Set<Models.Manufacture>(), "ManufactureId", "ManufactureId");
            return Page();
        }

        [BindProperty]
        public Models.Brand Brand { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Brand.Add(Brand);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
