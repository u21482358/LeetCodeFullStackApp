using Microsoft.AspNetCore.Mvc;
using ResturauntViewing.Models.Models;
namespace ResturauntViewing.Models.ViewComponents
{
    public class SampleListViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(int countVal)
        {  // countval number of lists they want.
            List<int> List5 = new List<int>();
            List<int> List10 = new List<int>();
            List<int> List25 = new List<int>();
            List<int> unOrderedList = new List<int>();
            string fileName = "Lists.txt";
            var lines = File.ReadLines(fileName);
            for (int i = 0; i < 3; i++)
            {
                string element = lines.ElementAt(i).Trim();
                string[] values = element.Split(',');
                foreach (var value in values)
                {
                    var inValue = Int32.Parse(value);
                    switch (i)
                    {
                        case 0:
                            List5.Add(inValue);
                            break;
                        case 1:
                            List10.Add(inValue);
                            break;
                        case 2:
                            List25.Add(inValue);
                            break;

                    }
                }


            }
            return View("~/Views/Home/SampleList.cshtml");
        }
    }
}


