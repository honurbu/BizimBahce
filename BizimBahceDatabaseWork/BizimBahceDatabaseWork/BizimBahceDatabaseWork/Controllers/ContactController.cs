using BizimBahceDatabaseWork.FluentValidators;
using BizimBahceDatabaseWork.Models.Context;
using BizimBahceDatabaseWork.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BizimBahceDatabaseWork.Controllers
{
    public class ContactController : Controller
    {
        Context context = new Context();


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            MessageValidator _msgValidator = new MessageValidator();

            var result = _msgValidator.Validate(message);
            if (result.IsValid)
            {
                context.Messages.Add(message);
                context.SaveChanges();
                return RedirectToAction("Index");                
            }

            return View(message);
            
        }

    }
}
