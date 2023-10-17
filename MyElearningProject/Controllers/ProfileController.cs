using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Entities;
using MyElearningProject.DAL.Context;

namespace MyElearningProject.Controllers
{
    public class ProfileController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            string values = Session["CurrentMail"].ToString();
            int id = context.Students.Where(x => x.Email == values).Select(y => y.StudentID).FirstOrDefault();
            var courseList = context.Processes.Where(x => x.StudentID == id).ToList();
            ViewBag.mail = values;
            ViewBag.name = context.Students.Where(x => x.Email == values).Select(y => y.Name + " " + y.Surname).FirstOrDefault();

            return View(courseList);
        }

        public ActionResult ListVideo()
        {
            string values = Session["CurrentMail"].ToString();
            ViewBag.mail = values;
            ViewBag.name = context.Students.Where(x => x.Email == values).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            int id = context.Students.Where(x => x.Email == values).Select(y => y.StudentID).FirstOrDefault();
            var videoList = context.Processes.Where(x => x.StudentID == id).ToList();

            return View(videoList);
        }



        [HttpGet]
        public ActionResult Puanla()
        {

            var values = context.Courses.ToList();
            string v1 = Session["CurrentMail"].ToString();
            int id1 = context.Students.Where(x => x.Email == v1).Select(y => y.StudentID).FirstOrDefault();
            int id2 = context.Processes.Where(x => x.StudentID == id1).Select(y => y.CourseID).FirstOrDefault();
            ViewBag.courseid = id2;
            ViewBag.course = context.Courses.Where(x => x.CourseID == id2).Select(y => y.Title).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Puanla(Review review)
        {
            var email = Session["CurrentMail"];

            var studentID = context.Students.Where(x => x.Email == email.ToString()).Select(x => x.StudentID).FirstOrDefault();
            review.StudentID = studentID;
            context.Reviews.Add(review);

            context.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
    }
}