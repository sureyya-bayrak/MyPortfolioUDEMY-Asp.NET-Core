using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.View_Component
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
