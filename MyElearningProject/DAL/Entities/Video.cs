using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Video
    {
        [Key]
        public int VideoID { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
    }
}