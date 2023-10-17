using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class HomeSlider
    {
        [Key]
        public int SliderID { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Slogan { get; set; }
        public string Comment { get; set; }
    }
}