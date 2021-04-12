using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string BrandName { get; set; }



        public Manufacture Manufacture { get; set; }
        public int ManufactureId { get; set; }
        public ICollection<Bikes> Bikes { get; set; }
    }
}
