using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Galery
    {
        [Key]
        public int ID { get; set; }
        public string ImageName { get; set; }
        public DateTime Date  { get; set; }
        public string ImageUrl  { get; set; }
    }
}