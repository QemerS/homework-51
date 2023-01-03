using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OxuAz.Models
{
    public class Image
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [Column(TypeName = "nText")]
        public string Link { get; set; }
        public List<Setting> Settings { get; set; }
        public List<Article> Articles { get; set; }
    }
}
