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
    public class HomeController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HomeHead()
        {
            return PartialView();
        }

        public PartialViewResult HomeSpinner()
        {
            return PartialView();
        }

        public PartialViewResult HomeNavBar()
        {
            return PartialView();
        }

        public PartialViewResult HomeSlider()
        {
            var values = context.HomeSliders.ToList();
            return PartialView(values);
        }


        public PartialViewResult HomeFeature()
        {
            var values = context.FeatureSkills.ToList();
            return PartialView(values);
        }

        AboutUsandFetatured af = new AboutUsandFetatured();
        public PartialViewResult HomeAboutUs()
        {
            af.deger1 = context.AboutUs.ToList();
            af.deger2 = context.AboutUsFeatureds.ToList();
            return PartialView(af);
        }
        public PartialViewResult HomeCourseCategory()
        {
            ViewBag.d1 = context.Categories.Where(x => x.CategoryID == 1).Select(y => y.CategoryName).FirstOrDefault();
            ViewBag.d2 = context.Categories.Where(x => x.CategoryID == 2).Select(y => y.CategoryName).FirstOrDefault();
            ViewBag.d3 = context.Categories.Where(x => x.CategoryID == 3).Select(y => y.CategoryName).FirstOrDefault();
            ViewBag.d4 = context.Categories.Where(x => x.CategoryID == 4).Select(y => y.CategoryName).FirstOrDefault();

            ViewBag.r1 = context.Categories.Where(x => x.CategoryID == 1).Select(y => y.ImageURl).FirstOrDefault();
            ViewBag.r2 = context.Categories.Where(x => x.CategoryID == 2).Select(y => y.ImageURl).FirstOrDefault();
            ViewBag.r3 = context.Categories.Where(x => x.CategoryID == 3).Select(y => y.ImageURl).FirstOrDefault();
            ViewBag.r4 = context.Categories.Where(x => x.CategoryID == 4).Select(y => y.ImageURl).FirstOrDefault();

            ViewBag.a1 = context.Categories.Where(x => x.CategoryID == 1).Select(y => y.CoursePieces).FirstOrDefault();
            ViewBag.a2 = context.Categories.Where(x => x.CategoryID == 2).Select(y => y.CoursePieces).FirstOrDefault();
            ViewBag.a3 = context.Categories.Where(x => x.CategoryID == 3).Select(y => y.CoursePieces).FirstOrDefault();
            ViewBag.a4 = context.Categories.Where(x => x.CategoryID == 4).Select(y => y.CoursePieces).FirstOrDefault();

            return PartialView();
        }
        public PartialViewResult HomePopularCourse()
        {
            var values = context.Courses.ToList();
            return PartialView(values);
        }
        public PartialViewResult HomeInstructor()
        {
            var values = context.Instructors.ToList();
            return PartialView(values);
        }

        public PartialViewResult HomeTestimonial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }

        ContactandAdress ca = new ContactandAdress();
        public PartialViewResult HomeFooter()
        {
            ca.Addresses = context.Addresses.ToList();
            ca.Galeries = context.Galeries.ToList();
            return PartialView(ca);
        }

        public PartialViewResult HomeScript()
        {
            return PartialView();
        }

        public ActionResult HomeGalery()
        {
            ViewBag.breadcrumb = "Galeri";
            var value = context.Galeries.ToList();
            return View(value);
        }


        public ActionResult AdminHomeGaleryIndex()
        {
            ViewBag.breadcrumb = "Galeri";
            var value = context.Galeries.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult UpdateAdminHomeGaleryIndex(int id)
        {
            ViewBag.breadcrumb = "Galeri - Resim Düzenleme";
            var value = context.Galeries.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateAdminHomeGaleryIndex(Galery galery)
        {

            var value = context.Galeries.Find(galery.ID);
            value.ImageUrl = galery.ImageUrl;
            value.ImageName = galery.ImageName;
            value.Date = galery.Date;
            context.SaveChanges();
            return RedirectToAction("AdminHomeGaleryIndex");
        }

        public ActionResult DeleteAdminHomeGaleryIndex(int id)
        {
            var value = context.Galeries.Find(id);
            context.Galeries.Remove(value);
            context.SaveChanges();
            return RedirectToAction("AdminHomeGaleryIndex");
        }

        [HttpGet]
        public ActionResult AddAdminHomeGaleryIndex()
        {
            ViewBag.breadcrumb = "Galeri - Resim Ekleme";
            return View();
        }


        [HttpPost]
        public ActionResult AddAdminHomeGaleryIndex(Galery galery)
        {

            var value = context.Galeries.Add(galery);
            context.SaveChanges();
            return RedirectToAction("AdminHomeGaleryIndex");
        }
    }
}