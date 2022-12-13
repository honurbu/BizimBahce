using Microsoft.AspNetCore.Mvc;

namespace BizimBahceDatabaseWork.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error(int code)
        {
            return View();
        }
    }
}
