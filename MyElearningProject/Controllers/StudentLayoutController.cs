using MyElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class StudentLayoutController : Controller
    {
        ELearningContext contex = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult StudentSideBar()
        {
            return PartialView();
        }

        public PartialViewResult TopNavbar()
        {
            
            ViewBag.Name=Session["KullaniciAdi"];
            ViewBag.Surname=Session["KullaniciSoyadi"];
            return PartialView();
        }

        public PartialViewResult StudentHeader()
        {
            return PartialView();
        }
    }
}