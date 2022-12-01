using BizimBahceDatabaseWork.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    [Area("Adminss")]
    public class DashboardController : Controller
    {
        Context context = new Context();
        public IActionResult Dashboard()
        {

            ViewBag.Oils = context.OliveOils.Count();
            ViewBag.Comments = context.Comments.Count();
            ViewBag.Messages = context.Messages.Count();
            var values = context.Admins.ToList();

            return View(values);
        }
    }
}
