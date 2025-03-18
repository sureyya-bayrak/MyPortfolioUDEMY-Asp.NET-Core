using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.View_Component
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() {
            return View();
            
        }
    }
}
