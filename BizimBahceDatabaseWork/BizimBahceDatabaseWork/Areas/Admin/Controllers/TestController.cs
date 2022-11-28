using Microsoft.AspNetCore.Mvc;

namespace BizimBahceDatabaseWork.Areas.Admin.Controllers
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
