using Microsoft.AspNetCore.Mvc;

namespace ResturauntViewing.Controllers
{
    public class DoubleListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sort(List<int> data, List<int> data2)
        {

            //List<int> numbers = ListHelperClass.ReturnInList(fc, null);
            //numbers.Sort();
            return View("~/Views/Home/People.cshtml");
        }
    }
}
