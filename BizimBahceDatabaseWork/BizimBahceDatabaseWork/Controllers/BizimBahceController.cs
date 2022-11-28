using BizimBahceDatabaseWork.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizimBahceDatabaseWork.Controllers
{
    public class BizimBahceController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }

    }
}
