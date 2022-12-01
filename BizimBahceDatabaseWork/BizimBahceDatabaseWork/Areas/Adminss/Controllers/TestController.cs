using Microsoft.AspNetCore.Mvc;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    public class TestController : Controller
    {
        [Area("Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
