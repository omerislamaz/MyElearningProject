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
    public class AboutUsController : Controller
    {
        ELearningContext context = new ELearningContext();

        AboutUsandFetatured ab = new AboutUsandFetatured();
        public ActionResult Index()
        {
            ViewBag.breadcrumb = "Hakkımızda";
            ab.deger1 = context.AboutUs.ToList();
            ab.deger2 = context.AboutUsFeatureds.ToList();
            return View(ab);
        }

        [HttpGet]
        public ActionResult UpdateAboutUs(int id)
        {
            ViewBag.breadcrumb = "Hakkımızda - Özellik Güncelleme";
            var value = context.AboutUs.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAboutUs(AboutUs aboutUs)
        {

            var value = context.AboutUs.Find(aboutUs.AboutUsID);
            value.Title = aboutUs.Title;
            value.Comment = aboutUs.Comment;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult AddFeature()
        {
            ViewBag.breadcrumb = "Hakkımızda - Yeni Özellik Ekleme";
            var value = context.AboutUsFeatureds.ToList();
            return View(value);
        }

        [HttpPost]
        public ActionResult AddFeature(AboutUsFeatured aboutUsFeatured)
        {
            context.AboutUsFeatureds.Add(aboutUsFeatured);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFeature(int id)
        {
            var value = context.AboutUsFeatureds.Find(id);
            context.AboutUsFeatureds.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {

            ViewBag.breadcrumb = "Hakkımızda - Özellik Güncelleme";
            var value = context.AboutUsFeatureds.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateFeature(AboutUsFeatured aboutUsFeatured)
        {
            var value = context.AboutUsFeatureds.Find(aboutUsFeatured.FeaturedID);
            value.FeaturedName = aboutUsFeatured.FeaturedName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}