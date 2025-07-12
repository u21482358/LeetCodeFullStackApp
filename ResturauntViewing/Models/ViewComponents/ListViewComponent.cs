using Microsoft.AspNetCore.Mvc;
using ResturauntViewing.Models.Models;
namespace ResturauntViewing.Models.ViewComponents
{
    public class ListViewComponent: ViewComponent
    {


        public async Task<IViewComponentResult> InvokeAsync(int countVal) // countval number of lists they want.
        {
            // Your logic for preparing data
            int count = 0;
            Person ps = new Person();
            count++;
            if (countVal == 1)
            {
                ViewData["Message"] = "Please enter number one.";
            }
            else
            {
                ViewData["Message"] = "Please enter number two.";
                count = 0;
            }
            if (count == countVal)
            {

            }

            return View("~/Views/Home/People.cshtml", ps); //"~/Views/FooBar/Baz/_MessagingPartial.cshtml"
        }
    }
}
