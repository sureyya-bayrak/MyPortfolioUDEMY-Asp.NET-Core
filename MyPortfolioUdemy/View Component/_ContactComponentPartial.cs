using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.View_Component
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
