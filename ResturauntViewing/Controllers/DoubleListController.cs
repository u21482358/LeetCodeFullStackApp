using Microsoft.AspNetCore.Mvc;

namespace ResturauntViewing.Controllers
{
    public class DoubleListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
