using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.View_Component
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() {
            return View();
        }


    }
}
