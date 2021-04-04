using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Bookings
    {
        public int ID { get; set; }
        public int? Duration { get; set; }
        public string WeekOrDay { get; set; }
        public int? TotalPrice { get; set; }
        public string Currency { get; set; }
        public int? Quantity { get; set; }

        public int CustomerID { get; set; }
        public Customers Customers { get; set; }

        public int BikeID { get; set; }
        public Bikes Bikes { get; set; }




    }
}
