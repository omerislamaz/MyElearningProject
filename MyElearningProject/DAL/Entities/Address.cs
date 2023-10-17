using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Adres { get; set; }
        public string GoogleAddressLink { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string X { get; set; }
    }
}