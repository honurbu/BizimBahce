using BizimBahceDatabaseWork.FluentValidators;
using BizimBahceDatabaseWork.Models.Context;
using BizimBahceDatabaseWork.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBahceDatabaseWork.Areas.Adminss.Controllers
{
    [Area("Adminss")]


    [Authorize]

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
            return RedirectToAction("ManageOils", "AdminProduct");
        }



        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = context.OliveOils.Find(id);

            return View(values);

        }

        [HttpPost]
        public IActionResult UpdateProduct(OliveOil oliveOil)
        {
            var oils = context.OliveOils.Find(oliveOil.OliveOilsID);

            oils.OliveOilPrice.OliveOilPriceLiter = oliveOil.OliveOilPrice.OliveOilPriceLiter;
            oils.OliveOilProperty.OliveOilDescription = oliveOil.OliveOilProperty.OliveOilDescription;
            oils.OliveOilType.OliveOilDescription = oliveOil.OliveOilType.OliveOilDescription;

            context.OliveOils.Update(oils);
            context.SaveChanges();

            return RedirectToAction("ManageOils", "AdminProduct");
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(OliveOil oil, OliveOilBenefit benefit, OliveOilPrice price, OliveOilProperty prop, OliveOilType type)
        {
            OilsValidator _oilsValidator = new OilsValidator();
            var result = _oilsValidator.Validate(oil);

            OilsPropValidator _oilsPropValdidator = new OilsPropValidator();
            var result2 = _oilsPropValdidator.Validate(prop);

            if (result.IsValid)
            {

                context.OliveOils.Add(oil);
                context.OliveOilBenefits.Add(benefit);
                context.OliveOilPrices.Add(price);
                context.OliveOilTypes.Add(type);               
                context.OliveOilProperties.Add(prop);
                

                context.SaveChanges();


                return RedirectToAction("ManageOils", "AdminProduct");

            }
            else
                return View(oil);

        }



    }
}
