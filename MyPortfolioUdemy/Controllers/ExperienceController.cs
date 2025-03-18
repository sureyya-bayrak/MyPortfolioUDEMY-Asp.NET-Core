﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow.ValueContentAnalysis;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();

            return View(values);
        }
        [HttpGet]
        //HttpGet ne için kullanılır?
        //HttpPost ne için kullanılır?
        //İkisi arasındaki farklar nelerdir?
        //HttpGET: Sayfaya giriş yaptığımızda çalışan actionlardır. Sayfa yüklendiğinde çalışır.
        //HttpPost: Sayfada bir butona tıkladığımızda çalışan actionlardır
        public IActionResult CreateExperience()
        {
            return View();
        }
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");

        }



        public IActionResult DeleteExperience(int id)
        {

            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");



        }


        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult CancelUpdateExperience()
        {   
            return RedirectToAction("ExperienceList");
        }
    }
}
