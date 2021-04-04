using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Bikes
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }

        public ICollection<Bookings> Bookings { get; set; }
    }
}
