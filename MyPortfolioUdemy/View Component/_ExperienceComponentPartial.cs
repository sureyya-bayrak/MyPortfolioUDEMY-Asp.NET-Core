﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.View_Component
{
    public class _ExperienceComponentPartial: ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke() {

            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
