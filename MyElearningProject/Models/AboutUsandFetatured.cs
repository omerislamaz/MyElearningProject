using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.Models
{
    public class AboutUsandFetatured
    {
        public IEnumerable<AboutUs> deger1 { get; set; }
        public IEnumerable<AboutUsFeatured> deger2 { get; set; }
    }
}