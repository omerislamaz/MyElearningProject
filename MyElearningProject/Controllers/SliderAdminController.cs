using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class SliderAdminController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            ViewBag.breadcrumb = "Slider";
            var values = context.HomeSliders.ToList();
            return View(values);
        }

      
        [HttpGet]
        public ActionResult UpdateSliderAdmin(int id)
        {
            ViewBag.breadcrumb = "Slider - Slider Güncelleme";
            var value = context.HomeSliders.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSliderAdmin(HomeSlider homeSlider)
        {
            
            var value = context.HomeSliders.Find(homeSlider.SliderID);
            value.Title = homeSlider.Title;
            value.Comment = homeSlider.Comment;
            value.ImageUrl = homeSlider.ImageUrl;
            value.Slogan = homeSlider.Slogan;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult AddSliderAdmin()
        {
            ViewBag.breadcrumb = "Slider - Yeni Slider Ekleme";
           
            return View();
        }

        [HttpPost]
        public ActionResult AddSliderAdmin(HomeSlider homeSlider)
        {
            context.HomeSliders.Add(homeSlider);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSliderAdmin(int id)
        {
            var value = context.HomeSliders.Find(id);
            context.HomeSliders.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

      

    }
}