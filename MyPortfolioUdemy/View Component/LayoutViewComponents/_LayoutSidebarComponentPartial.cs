using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.View_Component.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{

		public IViewComponentResult Invoke() {
			return View();

		}
	}
}
