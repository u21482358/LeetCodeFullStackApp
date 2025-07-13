using Microsoft.AspNetCore.Mvc;
using ResturauntViewing.Models.Models;
using System.Diagnostics;

namespace ResturauntViewing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? val)
        { // the Action Result returns a view of the product object which needs to be initialized before its returned.
            Product pr = new Product();
            Person ps = new Person();
            ViewData["num"] = (int)0;
            if (val.HasValue)
            {
                 ViewData["num"] = (int)val;
            }
            //ViewData["Message"] = "Your application description page.";
            return View(pr);
            var ps2 = new Product()
            {
                Id = pr.Id,
            };
        }

        public IActionResult People(int num)
        { // the Action Result returns a view of the product object which needs to be initialized before its returned.
            Product pr = new Product();
            Person ps = new Person();
            //ViewData["Number"] = 2;
            ViewData["Message"] = "Your application description page.";
            // return PartialView(ps); why isnt partialview going through?
            return ViewComponent("People");
            var ps2 = new Product()
            {
                Id = pr.Id,
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SampleList(int? val)
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
