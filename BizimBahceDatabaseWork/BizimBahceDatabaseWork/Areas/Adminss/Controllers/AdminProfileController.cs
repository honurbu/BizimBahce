using BizimBahceDatabaseWork.Models.Context;
using BizimBahceDatabaseWork.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    [Area("Adminss")]


    [Authorize]

    public class AdminProfileController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult Index(int id=1)
        {

            Admin admin = new Admin();
            if (id == null)
            {
                return View(admin);
            }

            admin = context.Admins.FirstOrDefault(x => x.AdminID == id);

            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        [HttpPost]
        public IActionResult Index(Admin admin)
        {
            var values = context.Admins.Find(admin.AdminID);

            values.Username = admin.Username;
            values.Mail = admin.Mail;
            values.About = admin.About;
            values.Password = admin.Password;
            context.Admins.Update(values);
            context.SaveChanges();
            return RedirectToAction("Dashboard","Dashboard");
        }
    }
}


//parametre gitmediği için güncelleme işlemi gerçekleşmiyor. Aynı durum Ürün Güncellede de mevcut.s