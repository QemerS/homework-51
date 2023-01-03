using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OxuAz.Models
{
    public class Article
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }

        [ForeignKey("Image")]
        public int ImageID { get; set; }
        public Image Image { get; set; }

        public DateTime Published { get; set; }
        public int Views { get; set; }

        [Column(TypeName = "nText")]
        public string Text { get; set; }

        public List<Like> Likes { get; set; }
        public List<Dislike> Dislikes { get; set; }
        public List<Comment> Comments { get; set; }
        public List<CategoryToArticle> CategoryToArticles { get; set; }
    }
}
