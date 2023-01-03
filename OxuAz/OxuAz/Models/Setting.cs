using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OxuAz.Models
{
    public class Setting
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nText")]
        public string About { get; set; }
        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public Address Address { get; set; }

        [ForeignKey("Phone")]
        public int PhoneID { get; set; }
        public Phone Phone { get; set; }

        [ForeignKey("Email")]
        public int EmailID { get; set; }
        public Email Email { get; set; }

        [ForeignKey("Social")]
        public int SocialID { get; set; }
        public Social Social { get; set; }

        [ForeignKey("Image")]
        public int LogoID { get; set; }
        public Image Image { get; set; }
    }
}
