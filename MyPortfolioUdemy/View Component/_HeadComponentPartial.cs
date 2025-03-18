using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.View_Component
{
    public class _HeadComponentPartial : ViewComponent

    {

        public IViewComponentResult Invoke()
        { //İndex.cshtml dosyasında çağırılan view componentin içeriği burada olacak.
          
            return View();

        }
    }
}
