using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult All()
        {
            ////cats fetched from database.
            //var cats = new List<string>
            //{
            //    "Pesho",
            //    "Gosho"
            //};

            ////  ViewData["Cats"] = cats;
            //// return View();

            //ViewBag.Cats = cats;
            //return View(cats);



            var cats = new List<CatViewModel>
            {
                new CatViewModel { Name = "Pesho", Age = 12 },
                new CatViewModel { Name = "Gosho", Age = 3 },
            };
            return View(cats);
        }
    }
}
