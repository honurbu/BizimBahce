using Microsoft.AspNetCore.Mvc;

namespace BizimBahceDatabaseWork.Controllers
{
    public class TestProduct : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
