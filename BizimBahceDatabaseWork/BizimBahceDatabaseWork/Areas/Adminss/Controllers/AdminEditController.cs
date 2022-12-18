using BizimBahceDatabaseWork.Models.Context;
using BizimBahceDatabaseWork.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    [Area("Adminss")]


    [Authorize]

    public class AdminEditController : Controller
    {
        Context context = new Context();

        public IActionResult ListAdmin()
        {
            return View();
        }

        [HttpPost]
         public IActionResult AdminEdit(Admin admin)
         {
           
             var admins = context.Admins.Find(admin.AdminID);
             admins.Username = admin.Username;
             admins.About=admin.About;
             admins.Mail = admin.Mail;
             admins.Password=admin.Password;
             context.SaveChanges();
             return RedirectToAction("Index","Dashboard");

         }
    }
}
