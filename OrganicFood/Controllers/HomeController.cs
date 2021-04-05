using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrganicFood.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using OrganicFood.GetData;
using OrganicFood.ViewModels;

namespace OrganicFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Price()
        {
            GetGoods gg = new GetGoods(); // чтение списка из БД

            PriceModelView priceModel = new PriceModelView()
            {
                Goods = gg.GetPriceList(),
                Category = gg.GetCategoryList()
            };

            return View(priceModel);
        }

        public IActionResult Recept()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
