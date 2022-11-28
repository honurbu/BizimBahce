using Microsoft.AspNetCore.Mvc;

namespace BizimBahceDatabaseWork.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
