using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;


namespace WebApplication3.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication3.Data.WebApplication3Context _context;

        public IndexModel(WebApplication3.Data.WebApplication3Context context)
        {
            _context = context;
        }


        public string IdSort { get; set; }

        public IList<Models.Bookings> Booking { get;set; }


        public async Task OnGetAsync(string sortOrder)
        {


            IdSort = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";



            IQueryable<Models.Bookings> bookingsIQ = from b in _context.Bookings select b;

            switch (sortOrder)
            {
                case "id_desc":
                    bookingsIQ = bookingsIQ.OrderByDescending(b => b.CustomerId);
                    break;
                default:
                    bookingsIQ = bookingsIQ.OrderBy(b => b.BookingId);
                    break;
            }
            // connects Customer and Bike models to Booking
            Booking = await bookingsIQ
                .Include(b => b.Customer)
                .Include(b => b.Bike)
                .ToListAsync();

        }
    }
}
