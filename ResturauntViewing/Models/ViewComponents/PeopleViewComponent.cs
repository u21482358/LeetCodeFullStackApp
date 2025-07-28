using Microsoft.AspNetCore.Mvc;
using ResturauntViewing.Models.Models;

namespace ResturauntViewing.Models.ViewComponents
{
    [ViewComponent(Name = "People")]
    public class PeopleViewComponent : ViewComponent
    {
        private int count = 0;
        public async Task<IViewComponentResult> InvokeAsync(int countVal) // countval number of lists they want.
        {
            // Your logic for preparing data
            Person ps = new Person();
            count++;
            ViewData["Message"] = "Your application description page.";
            if (countVal == 1)
            {
                ViewData["Message"] = 1;
            }
            else
            {
                ViewData["Message"] = 2;
                count = 0;
            }
            if (count == countVal)
            {

            }

            return View("~/Views/Home/People.cshtml", ps); //"~/Views/FooBar/Baz/_MessagingPartial.cshtml"
        }
    }


}
