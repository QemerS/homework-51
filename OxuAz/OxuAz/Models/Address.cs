using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OxuAz.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(20)]
        public string Country { get; set; }
        [MaxLength(10)]
        public string City { get; set; }
        [MaxLength(10)]
        public string Area { get; set; }
        [MaxLength(10)]
        public string Street { get; set; }
        [MaxLength(10)]
        public string Building { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public List<Setting> Settings { get; set; }
    }
}
