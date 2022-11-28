using BizimBahceDatabaseWork.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizimBahceDatabaseWork.ViewComponents.Contact
{
    public class Contacts:ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

    }
}
