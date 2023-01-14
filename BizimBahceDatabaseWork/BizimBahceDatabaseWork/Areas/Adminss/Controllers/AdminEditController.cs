using BizimBahceDatabaseWork.Models.Context;
using BizimBahceDatabaseWork.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    [Area("Adminss")]


    [Authorize]

    public class AdminEditController : Controller
    {
        Context context = new Context();

        public IActionResult ListAdmin()
        {
            var values = context.Admins.ToList();
            return View(values);
        }



        [HttpGet]
        public IActionResult AdminEdit(int id)
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
        public IActionResult AdminEdit(Admin admin)
        {

            var admins = context.Admins.Find(admin.AdminID);

            admins.Username = admin.Username;
            admins.About = admin.About;
            admins.Mail = admin.Mail;
            admins.Password = admin.Password;




            context.Update(admins);
            context.SaveChanges();
            return RedirectToAction("Dashboard", "Dashboard");

        }
    }
}
