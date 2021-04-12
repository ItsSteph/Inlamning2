using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        //seeding data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<Customers>()
                .HasData(
                    new Customers { CustomerId = 1, FirstName = "Anna", LastName = "Johnson", EmailAddress = "jonse@hotmail.com", PhoneNumber = 123456789 },
                    new Customers { CustomerId = 2, FirstName = "Eivind", LastName = "Ingemann", EmailAddress = "eivindarbast@ingemann.se", PhoneNumber = 123456789 },
                    new Customers { CustomerId = 3, FirstName = "Magdalena", LastName = "Nilson", EmailAddress = "magdalena.nilson@hotmail.com", PhoneNumber = 123456789 },
                    new Customers { CustomerId = 4, FirstName = "Herman", LastName = "Nilson", EmailAddress = "herman.nilson@hotmail.com", PhoneNumber = 123456789 },
                    new Customers { CustomerId = 5, FirstName = "Gullwi", LastName = "Josefsson", EmailAddress = "gullwijose@gmail.com", PhoneNumber = 123456789 },
                    new Customers { CustomerId = 6, FirstName = "Kalle", LastName = "Blomqvist", EmailAddress = "masterdetectiv@protonmail.com", PhoneNumber = 123456789 },
                    new Customers { CustomerId = 7, FirstName = "Julia", LastName = "Hernandéz", EmailAddress = "hernandez.julia@yahoo.com", PhoneNumber = 123456789 },
                    new Customers { CustomerId = 8, FirstName = "Felix", LastName = "Ingvarsson", EmailAddress = "felixfelicis@gmail.com", PhoneNumber = 123456789 },
                    new Customers { CustomerId = 9, FirstName = "Matts", LastName = "Olson", EmailAddress = "olsongänget@gmail.com", PhoneNumber = 123456789 },
                    new Customers { CustomerId = 10, FirstName = "Linda", LastName = "Nyberg", EmailAddress = "Linda@Nyberg.se", PhoneNumber = 123456789 }
                );

            modelBuilder
                .Entity<Bookings>()
                .HasData(
                    new Bookings { BookingId = 1, Duration = "1 DAY", Quantity = 1, CustomerId = 1, BikeId = 1, },
                    new Bookings { BookingId = 2, Duration = "1 DAY", Quantity = 1, CustomerId = 1, BikeId = 1 },
                    new Bookings { BookingId = 3, Duration = "1 DAY", Quantity = 1, CustomerId = 6, BikeId = 3 },
                    new Bookings { BookingId = 4, Duration = "1 DAY", Quantity = 1, CustomerId = 7, BikeId = 2 },
                    new Bookings { BookingId = 5, Duration = "1 DAY", Quantity = 1, CustomerId = 2, BikeId = 1 },
                    new Bookings { BookingId = 6, Duration = "1 DAY", Quantity = 1, CustomerId = 9, BikeId = 5 }
                );

            modelBuilder
                .Entity<Bikes>()
                .HasData(

                    new Bikes { BikeId = 1, Model = "Community S", Price = 300, Currency = "SEK", BrandId = 1},
                    new Bikes { BikeId = 2, Model = "Women's Cruiser", Price = 375, Currency = "SEK", BrandId = 2},
                    new Bikes { BikeId = 3, Model = "City Classic", Price = 300, Currency = "SEK", BrandId = 3},
                    new Bikes { BikeId = 4, Model = "Speed Roller+", Price = 300, Currency = "SEK", BrandId = 2},
                    new Bikes { BikeId = 5, Model = "Street 687", Price = 450, Currency = "SEK", BrandId = 3},
                    new Bikes { BikeId = 6, Model = "Urban City Commuter", Price = 300, Currency = "SEK", BrandId = 1}
                );

            modelBuilder
                .Entity<Manufacture>()
                .HasData(
                    new Manufacture {ManufactureId = 1, ManufactureName = "Biltema"},
                    new Manufacture { ManufactureId = 2, ManufactureName = "Huffy" },
                    new Manufacture { ManufactureId = 3, ManufactureName = "Kildemose" }
                );

            modelBuilder
                .Entity<Brand>()
                .HasData(
                    new Brand {BrandId = 1, BrandName = "Yosemity", ManufactureId = 1},
                    new Brand {BrandId = 2, BrandName = "Nassau", ManufactureId = 2},
                    new Brand {BrandId = 3, BrandName = "Kildemose", ManufactureId = 3}
                );

        }

        public DbSet<WebApplication3.Models.Bikes> Bikes { get; set; }

        public DbSet<WebApplication3.Models.Bookings> Bookings { get; set; }

        public DbSet<WebApplication3.Models.Customers> Customers { get; set; }

        public DbSet<WebApplication3.Models.Brand> Brand { get; set; }

        public DbSet<WebApplication3.Models.Manufacture> Manufacture { get; set; }

    }
}
