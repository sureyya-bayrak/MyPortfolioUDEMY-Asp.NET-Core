using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
    public class DefaultController : Controller
    {

        //Controller sınıfları Controller sınıfından miras alır.
        //Controller sınıfları MVC mimarisinde kullanılır.
        //Controller back end kodlarımızı yazdığımız alandır.
        
        public IActionResult Index()
        {
            //Index metodu bir IAcitonResult tipinde dönüş yapar.
            //IActionResult bir interface'dir.
            //IActionResult interface'i içerisinde ViewResult, JsonResult, PartialViewResult, RedirectResult gibi metotlar bulunur.

            return View();
        }
    }
}
