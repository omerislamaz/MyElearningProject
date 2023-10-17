using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class FeatureSkill
    {
        [Key]
        public int SkillID { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string IconUrl { get; set; }
    }
}