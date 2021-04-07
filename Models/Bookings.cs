using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Bookings
    {
        [Key]
        public int BookingId { get; set; }
        public string Duration { get; set; }
        public int? Quantity { get; set; }
        public Customers Customer { get; set; }
        public int CustomerId { get; set; }


        public Bikes Bike { get; set; }

        public int BikeId { get; set; }


    }
}
