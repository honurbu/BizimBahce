using BizimBahceDatabaseWork.Models.Context;
using BizimBahceDatabaseWork.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    [Area("Adminss")]

    public class AdminProductController : Controller
    {
        Context context = new Context();


        public async Task<List<OliveOil>> GetListWithOliveOilProperty()
        {

            var oliveOils = context.OliveOils
                .Include(x => x.OliveOilPrice)
                .Include(x => x.OliveOilBenefit)
                .Include(x => x.OliveOilProperty)
                .Include(x => x.OliveOilType);

            return await oliveOils.ToListAsync();
        }

        public async Task<IActionResult> ManageOils()
        {
            var oliveOils = await GetListWithOliveOilProperty();
            return View(oliveOils);
        }

        public IActionResult ProductDelete(int id)
        {
            var products = context.OliveOils.Find(id);
            context.Remove(products);
            context.SaveChanges();
            return RedirectToAction("ManageOils","AdminProduct");
        }





        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = context.OliveOils.Find(id);
            return View();

        }



    }
}
