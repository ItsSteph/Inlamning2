using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Bikes
    {
        [Key]
        public int BikeId { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }


        public ICollection<Bookings> Bookings { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }


    }
}
