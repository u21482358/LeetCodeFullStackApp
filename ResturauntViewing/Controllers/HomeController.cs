using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using ResturauntViewing.Models.Models;
using System.Diagnostics;
using System.Reflection;

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

        public IActionResult Landing()
        {
            string fileName = "Leetcode.txt";
            var lines = System.IO.File.ReadLines(fileName).Skip(1);

            List<LeetCodeViewModel> leetcodeModels = new List<LeetCodeViewModel>();
            foreach (var line in lines)
            {
                string[] leetObject = line.Split(";");
                LeetCodeViewModel leetCodeModel = new LeetCodeViewModel();
                leetCodeModel.Name = leetObject[0];
                leetCodeModel.type = leetObject[1];
                leetCodeModel.Action = leetObject[2];
                leetCodeModel.Controller = leetObject[3];
                leetCodeModel.ParameterValue = Int32.Parse(leetObject[4]);
                leetCodeModel.descriptionHref = leetObject[5];
                // Name;Type;Action;Controller;parameter;href
                leetcodeModels.Add(leetCodeModel);
            }
            // https://stackoverflow.com/questions/58206397/c-sharp-linq-group-to-a-list-inside-a-list

            var types = leetcodeModels.GroupBy(u => u.type).SelectMany(group => group)
                .Select(c => new LeetCodeViewModel { 
                Action = c.Action,
                Controller = c.Controller,
                ParameterValue = c.ParameterValue,
                type = c.type
                
                }).ToList(); // select many flattens the list https://stackoverflow.com/questions/958949/difference-between-select-and-selectmany
                                                                                                  


          

            // maybe group by something different if problems in future.
            ViewBag.types = types;
            return View(leetcodeModels);
        }

        public IActionResult SampleList(int? val)
        {

           

           
            return ViewComponent("SampleList");
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
