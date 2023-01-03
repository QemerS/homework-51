using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OxuAz.Models
{
    public class Phone
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(3)]
        public string AreaCode { get; set; }
        [MaxLength(3)]
        public string FirstGroupOfNums { get; set; }
        [MaxLength(4)]
        public string SecondGroupOfNums { get; set; }
        public List<Setting> Settings { get; set; }
    }
}
