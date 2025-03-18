using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.View_Component.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
