using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class InstructorLayoutController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult InstructorHead()
        {
            return PartialView();
        }


        public PartialViewResult InstructorNavBar()
        {
            ViewBag.Kullanici = Session["CurrentMail1"];
            return PartialView();
        }

        public PartialViewResult InstructorSideBar()
        {
            return PartialView();
        }


        public ActionResult CourseIndex()
        {
            ViewBag.breadcrumb = "Kurs Listesi";
                 


            
            return View();
        }

        [HttpGet]
        public ActionResult CreateCourse()
        {
            ViewBag.breadcrumb = "Kurs Oluştur";

            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.v = categories;

            List<SelectListItem> instructor = (from x in context.Instructors.OrderBy(x => x.Name).ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name + " " + x.Surname,
                                                   Value = x.InstructorID.ToString()
                                               }).ToList();
            ViewBag.i = instructor;
            return View();
        }


        [HttpPost]
        public ActionResult CreateCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCourse(int id)
        {
            var value = context.Courses.Find(id);
            context.Courses.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateCourse(int id)
        {
            ViewBag.breadcrumb = "Kurs Güncelle";

            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.v = categories;

            List<SelectListItem> instructor = (from x in context.Instructors.OrderBy(x => x.Name).ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name + " " + x.Surname,
                                                   Value = x.InstructorID.ToString()
                                               }).ToList();
            ViewBag.i = instructor;

            var value = context.Courses.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCourse(Course course)
        {
            var value = context.Courses.Find(course.CourseID);
            value.Title = course.Title;
            value.CategoryID = course.CategoryID;
            value.Duration = course.Duration;
            value.ImageUrl = course.ImageUrl;
            value.InstructorID = course.InstructorID;
            value.Price = course.Price;
            context.SaveChanges();
            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult AddVideo()
        {
            ViewBag.breadcrumb = "Kurs Oluştur - Video Ekleme";

            List<SelectListItem> courses = (from x in context.Courses.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.Title,
                                                Value = x.CourseID.ToString()
                                            }).ToList();
            ViewBag.course = courses;
            return View();
        }

        [HttpPost]
        public ActionResult AddVideo(Video video)
        {
            context.Videos.Add(video);
            context.SaveChanges();
            return RedirectToAction("Index");
        }




        [HttpGet]
        public ActionResult UpdateVideo(int id)
        {
            ViewBag.breadcrumb = "Video Güncelle";
            List<SelectListItem> courses = (from x in context.Courses.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.Title,
                                                Value = x.CourseID.ToString()
                                            }).ToList();
            ViewBag.course = courses;

            var value = context.Videos.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateVideo(Video video)
        {
            var value = context.Videos.Find(video.VideoID);
            value.Title = video.Title;
            value.VideoUrl = video.VideoUrl;
            value.CourseID = video.CourseID;
            context.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult DeleteVideo(int id)
        {
            var value = context.Videos.Find(id);
            context.Videos.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}