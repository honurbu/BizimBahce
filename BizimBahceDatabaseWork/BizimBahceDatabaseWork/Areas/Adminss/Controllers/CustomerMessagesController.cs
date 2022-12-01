using BizimBahceDatabaseWork.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    [Area("Adminss")]
    public class CustomerMessagesController : Controller
    {
        Context context = new Context();

        public IActionResult Index()
        {
            var messages = context.Messages.ToList();
            return View(messages);
        }
    }
}
