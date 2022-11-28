using BizimBahceDatabaseWork.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizimBahceDatabaseWork.Controllers
{
    public class AboutController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}
