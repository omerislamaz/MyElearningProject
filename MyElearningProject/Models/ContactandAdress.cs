using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.Models
{
    public class ContactandAdress
    {
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public IEnumerable<Galery> Galeries { get; set; }
    }
}