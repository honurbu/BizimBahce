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


        /* public List<OliveOil> GetListWithOliveOilProperty()
         {
             using (var c = new Context())
             {
                 return c.OliveOils.Include(x => x.OliveOilPrice).Include(x => x.OliveOilType).Include(x => x.OliveOilProperty).ToList();
             }
         }*/


        public async Task<List<OliveOil>> GetListWithOliveOilProperty()
        {

            /* var values = GetListWithOliveOilProperty().ToList();
             return View(values);

             var values = context.OliveOils.ToList();
             return View(values);*/

            var oliveOils = context.OliveOils.Include(x => x.OliveOilPrice)
                .Include(x => x.OliveOilBenefit)
                .Include(x => x.OliveOilProperty)
                .Include(x => x.OliveOilType);

            return await oliveOils.ToListAsync();
        }

        public async Task<IActionResult>Index()
        {

            /* var values = GetListWithOliveOilProperty().ToList();
             return View(values);

             var values = context.OliveOils.ToList();
             return View(values);*/

            var oliveOils = await GetListWithOliveOilProperty();
            return View(oliveOils);
        }
    }
}










//var values = GetListWithOliveOilProperty().ToList();

/*public List<OliveOil> GetListWithOliveOilProperty()
        {
            using (var c = new Context())
            {
                return c.OliveOils.Include(x => x.OliveOilType).Include(x=>x.OliveOilPrice).Include(x=>x.OliveOilProperty).ToList();
            }
        }*/