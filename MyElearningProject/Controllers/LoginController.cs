using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyElearningProject.Controllers
{
    public class LoginController : Controller
    {
        ELearningContext context = new ELearningContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student student)
        {
            var values = context.Students.FirstOrDefault(x => x.Email == student.Email && x.Password == student.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Email, false);
                Session["CurrentMail"] = values.Email;
                Session["KullaniciAdi"] = values.Name;
                Session["KullaniciSoyadi"] = values.Surname;
                Session.Timeout = 60;
                return RedirectToAction("Index", "Profile");
            }
            return View();
        }


        [HttpGet]
        public ActionResult InstructorLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InstructorLogin(Instructor instructor)
        {
            var values = context.Instructors.FirstOrDefault(x => x.EMail == instructor.EMail && x.Password == instructor.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.EMail, false);
                Session["CurrentMail1"] = values.EMail;
                Session.Timeout = 600;
                return RedirectToAction("Index", "InstructorAnalysis");
            }
            return View();
        }


        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(Instructor instructor)
        {
            var values = context.Instructors.FirstOrDefault(x => x.EMail == instructor.EMail && x.Password == instructor.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.EMail, false);
                Session["CurrentMail1"] = values.EMail;
                Session.Timeout = 600;
                return RedirectToAction("Index", "Course");
            }
            return View();
        }
    }
}