﻿using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class CategoryController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            ViewBag.breadcrumb = "Kategori";
            var values = context.Categories.ToList();
            return View(values);
        }



        [HttpGet]
        public ActionResult AddCategory()
        {
            ViewBag.breadcrumb = "Kategori - Yeni Kategori Ekleme";
            return View();
        }


        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
         
            context.Categories.Add(category);
            context.SaveChanges(); 
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            ViewBag.breadcrumb = "Kategori - Kategori Güncelleme";
            var value = context.Categories.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var value = context.Categories.Find(category.CategoryID);
            value.CategoryName = category.CategoryName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}