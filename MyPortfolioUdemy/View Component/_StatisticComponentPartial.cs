using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.View_Component
{
    public class _StatisticComponentPartial: ViewComponent
        {
        public IViewComponentResult Invoke()
        {
            return View();

        }


    }
}
