using BizimBahceDatabaseWork.Models.Context;
using BizimBahceDatabaseWork.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    [Area("Adminss")]
    public class CustomerCommentController : Controller
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

        

        public IActionResult CommentActive(int id)
        {

            var comm = context.Comments.Find(id);          
            comm.IsActive = true;            
            context.Update(comm);
            context.SaveChanges();

            return RedirectToAction("Index", "CustomerComment");
        }


        public IActionResult CommentDelete(int id)
        {

            var comm = context.Comments.Find(id);

            context.Comments.Remove(comm);
            context.SaveChanges();

            return RedirectToAction("Index", "CustomerComment");
        }

    }
}
