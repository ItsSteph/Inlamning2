﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Pages.Customers
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
        public Models.Customers Customers { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD

        //When posting data the program will check if everything is ok before saving and redirection you to the index page
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
