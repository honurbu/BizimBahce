using BizimBahceDatabaseWork.Models.Context;
using BizimBahceDatabaseWork.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBahceDatabaseWork.Controllers
{
    public class ProductController : Controller
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

        public async Task<IActionResult>Index()
        {
            var oliveOils = await GetListWithOliveOilProperty();
            return View(oliveOils);
        }
    }
}


