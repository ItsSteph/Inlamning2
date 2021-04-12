using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Manufacture
    {
        [Key]
        public int ManufactureId { get; set; }
        public string ManufactureName { get; set; }

        public ICollection<Brand> Brands { get; set; }
    }
}
