using Microsoft.AspNetCore.Mvc;
using ResturauntViewing.Models.Models;
namespace ResturauntViewing.Controllers
{
    public class ListController : Controller
    {
        //public IActionResult Sort(IFormCollection fc, IFormCollection fc2)
        //{
           
        //   List<int> numbers = ListHelperClass.ReturnInList(fc,null);
        //    numbers.Sort();
        //    return View("");
        //}

        public IActionResult Sort(List<int> data)
        {

            //List<int> numbers = ListHelperClass.ReturnInList(fc, null);
            //numbers.Sort();
            return View("");
        }
    }
}
