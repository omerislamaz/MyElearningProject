using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Process
    {
        [Key]
        public int ProcessID { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public int VideoID { get; set; }
        public virtual Video Video { get; set; }


    }
}