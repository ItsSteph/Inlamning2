using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }

        public int BookingID { get; set; }
        public ICollection<Bookings> Bookings { get; set; }
    }
}
