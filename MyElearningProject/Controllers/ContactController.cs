using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using MyElearningProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class ContactController : Controller
    {
        ELearningContext context = new ELearningContext();

        ContactandAdress ca = new ContactandAdress();

        [HttpGet]
        public ActionResult Index()
        {
            ca.Contacts = context.Contacts.ToList();
            ca.Addresses = context.Addresses.ToList();
            return View(ca);
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {

            ViewBag.breadcrumb = "Bize Yazın";

            ca.Contacts = context.Contacts.ToList();
            ca.Addresses = context.Addresses.ToList();
            context.Contacts.Add(contact);
            context.SaveChanges();
            return View(ca);
        }




        public ActionResult AdminAddressIndex()
        {
            ViewBag.breadcrumb = "İletişim Bilgileri";
            var value = context.Addresses.ToList();
            return View(value);
        }


        [HttpGet]
        public ActionResult UpdateAdminAdress(int id)
        {
            ViewBag.breadcrumb = "İletişim Bilgileri - Güncelleme Ekranı";
            var value = context.Addresses.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAdminAdress(Address address)
        {
            var value = context.Addresses.Find(address.ID);
            value.Adres = address.Adres;
            value.Email = address.Email;
            value.Telephone = address.Telephone;
            value.GoogleAddressLink = address.GoogleAddressLink;
            value.Facebook = address.Facebook;
            value.LinkedIn = address.LinkedIn;
            value.Instagram = address.Instagram;
            value.X = address.X;
            context.SaveChanges();
            return RedirectToAction("AdminAddressIndex");
        }




        public ActionResult MessageIndex()
        {
            ViewBag.breadcrumb = "İletişim - Gelen Mesajlar";
            var values = context.Contacts.ToList();
            return View(values);

        }

        public ActionResult DeleteMessage(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("MessageIndex");
        }
    }
}