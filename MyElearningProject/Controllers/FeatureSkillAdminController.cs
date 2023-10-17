using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class FeatureSkillAdminController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            ViewBag.breadcrumb = "Featured";
            var values = context.FeatureSkills.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateFeatureSkill(int id)
        {
            ViewBag.breadcrumb = "Featured - Featured Güncelleme";
            var value = context.FeatureSkills.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateFeatureSkill(FeatureSkill featureSkill)
        {
            var value = context.FeatureSkills.Find(featureSkill.SkillID);
            value.Title = featureSkill.Title;
            value.Comment = featureSkill.Comment;
            value.IconUrl = featureSkill.IconUrl;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}