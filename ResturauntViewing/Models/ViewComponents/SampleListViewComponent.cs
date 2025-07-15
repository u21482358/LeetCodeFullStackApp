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
            List<List<int>> allLists = new List<List<int>>(); // https://stackoverflow.com/questions/12628222/creating-a-list-of-lists-in-c-sharp
            allLists.Add(List5);
            allLists.Add(List10);
            allLists.Add(List25);
            SampleListViewModel model = new SampleListViewModel();
            model.everyList = allLists;
            return View("~/Views/Home/SampleList.cshtml",model);
        }
    }
}


