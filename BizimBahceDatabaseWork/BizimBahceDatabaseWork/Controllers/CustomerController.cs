using BizimBahceDatabaseWork.FluentValidators;
using BizimBahceDatabaseWork.Models.Context;
using BizimBahceDatabaseWork.Models.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BizimBahceDatabaseWork.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();

        public List<Comment> GetListWithComment()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Customer).ToList();
            }
        }

        public IActionResult Index()
        {
            var values = GetListWithComment().ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Comment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Comment(Comment comment, Customer customer)
        {
            CommentValidator _commentvalidator = new CommentValidator();
            CustomerValidator _customervalidator = new CustomerValidator();

            var result = _commentvalidator.Validate(comment);
            var result2 = _customervalidator.Validate(customer);
            if (result.IsValid)
            {
                if (result2.IsValid)
                { 
                    context.Comments.Add(comment);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(comment);
            }

            return View(comment);
        }
    }
}
