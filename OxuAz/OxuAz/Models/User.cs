using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OxuAz.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string FbAccountName { get; set; }

        public List<Like> Likes { get; set; }
        public List<Dislike> Dislikes { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
