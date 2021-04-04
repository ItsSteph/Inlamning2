using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class WebApplication3Context : DbContext
    {
        public WebApplication3Context(DbContextOptions<WebApplication3Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Models.Bikes> Bikes { get; set; }

        public DbSet<WebApplication3.Models.Bookings> Bookings { get; set; }

        public DbSet<WebApplication3.Models.Customers> Customers { get; set; }

    }
}
