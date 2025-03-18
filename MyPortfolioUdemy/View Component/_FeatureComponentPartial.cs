﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.View_Component
{
    public class _FeatureComponentPartial : ViewComponent

    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
