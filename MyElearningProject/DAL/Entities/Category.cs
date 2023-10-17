using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ImageURl { get; set; }
        public string CoursePieces { get; set; }
        public string divclass { get; set; }
        public string divclassposition { get; set; }
        public string divclassstyle { get; set; }
        public string wowdelay { get; set; }
        public List<Course> Courses { get; set; }
    }
}