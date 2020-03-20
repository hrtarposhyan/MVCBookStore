using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileStore.Models;

namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        //вывод на веб-страницу

        MobileContext db;

        // ctor kontext dannix, vory vorpes service e avelacvac ConfigureServices() metodum
        //services.AddDbContext<MobileContext>(options =>
        //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        public HomeController(MobileContext context)
        {
            db = context;
        }

        // method Index для передачи пользователю данных о товарах, vori nerkayacman hamar ogtagorcvum e Index.chtml. view-n
        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }

        //функциональность для оформления заказов.

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.PhoneId = id;
            return View();
        }
        [HttpPost]
        public string  Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Շնորհակալություն," + order.User + ",Գնումների համար !!!!";
        }

    }
}
