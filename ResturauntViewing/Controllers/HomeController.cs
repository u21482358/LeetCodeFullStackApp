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
        public static LeetCodeViewModel lcvmClass;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index(int val)
        { // the Action Result returns a view of the product object which needs to be initialized before its returned.
            Product pr = new Product();
            Person ps = new Person();

            //ViewData["num"] = val2.ParameterValue;
           var lcvm = LeetCodeViewModel.FindModel(val);
            lcvmClass = lcvm;
            //if(lcvm.Type == )
           // ViewData["type"]
            ViewData["Message"] = "Your application description page.";
            ViewData["num"] = val; // this one line is incompatible.
            ViewData["model"] = lcvm;
            return View(lcvm);
            var ps2 = new Product()
            {
                Id = pr.Id,
            };
        }

        public IActionResult ViewRender(Boolean manualEntry)
        { // the Action Result returns a view of the product object which needs to be initialized before its returned.
            Product pr = new Product();
            Person ps = new Person();

            //ViewData["num"] = val2.ParameterValue
            //if(lcvm.Type == )
           lcvmClass.ManualEntry = manualEntry;
            ViewData["Message"] = "Your application description page.";
            
            
            return View("~/Views/Home/Index.cshtml", lcvmClass);
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
            var file = System.IO.File.ReadLines(fileName).Skip(1);
            List<LeetCodeViewModel> leetcodeModels = new List<LeetCodeViewModel>();
            //string[] lines = file.spl
            foreach (var line in file)
            {
                string[] leetObject = line.Split(";");
                LeetCodeViewModel leetCodeViewModel = new LeetCodeViewModel
                {
                    Id = Int32.Parse(leetObject[0]),
                    Name = leetObject[1],
                    Type = leetObject[2],
                    Action = leetObject[3],
                    Controller = leetObject[4],
                    ParameterValue = Int32.Parse(leetObject[5]),
                    DescriptionHref = leetObject[6],
                };
                leetcodeModels.Add(leetCodeViewModel);
            }
            // https://stackoverflow.com/questions/58206397/c-sharp-linq-group-to-a-list-inside-a-list
            
            var types = leetcodeModels.GroupBy(u => u.Type).SelectMany(group => group)
                .Select(c => new LeetCodeViewModel { 
                Action = c.Action,
                Controller = c.Controller,
                ParameterValue = c.ParameterValue,
                Type = c.Type
                
                }).ToList(); // select many flattens the list https://stackoverflow.com/questions/958949/difference-between-select-and-selectmany
                                                                                                  


          

            // maybe group by something different if problems in future.
            ViewBag.types = types;
            return View(leetcodeModels);
        }

        //public IActionResult LeetCodeEntry(int id)
        //{
        //   LeetCodeViewModel lcvm = LeetCodeViewModel.FindModel(id);
        //    string methodName = lcvm.Name;

        //    // call action with relevant name
        //    return View("")
        //}

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
