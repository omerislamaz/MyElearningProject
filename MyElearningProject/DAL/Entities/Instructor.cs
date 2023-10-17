﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }
        public string Name { get; set; }

        [StringLength(30)]
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }

        public List<Course> Courses { get; set; }
    }
}