using BizimBahceDatabaseWork.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizimBahceDatabaseWork.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerMessagesController : Controller
    {
        Context context = new Context();

        public IActionResult MessagePage()
        {
            var messages = context.Messages.ToList();
            return View(messages);
        }
    }
}
