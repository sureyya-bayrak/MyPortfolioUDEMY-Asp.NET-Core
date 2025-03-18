using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyPortfolioUdemy.View_Component.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
      public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
