using BizimBahceDatabaseWork.Models.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    [Area("Adminss")]
    [Authorize]

    public class DashboardController : Controller
    {
        Context context = new Context();

        //[Authorize]
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
