using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class AboutUsFeatured
    {
        [Key]
        public int FeaturedID { get; set; }
        public string FeaturedName { get; set; }
    }
}