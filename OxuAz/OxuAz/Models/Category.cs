using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OxuAz.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(10)]
        public string Name { get; set; }

        public List<CategoryToArticle> CategoryToArticles { get; set; }
    }
}
