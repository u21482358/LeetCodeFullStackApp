namespace ResturauntViewing.Models.Models
{
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using System.Threading;
    public class LeetCodeViewModel
    {
        // Interesting https://stackoverflow.com/questions/58206397/c-sharp-linq-group-to-a-list-inside-a-list
        public int? Id;
        public string Name;
        public string Type;
        public string Action;
        public string Controller;
        public int? ParameterValue;
        public Boolean ManualEntry = true;
        public string DescriptionHref;


        static int lastId = 0;
        //public LeetCodeViewModel() https://stackoverflow.com/questions/51641722/create-a-c-sharp-method-to-generate-auto-increment-id
        //{
        //    Id = Interlocked.Increment(ref lastId);
        //}
        // cant do this as needs to reconcile with the textbox

        public LeetCodeViewModel(int Id, string Name, string type, string Action, string Controller,  int ParaeterValue, string descriptionHref)
        {
            this.Id = Id;
            this.Type = type;
            this.DescriptionHref = descriptionHref;
            this.Controller = Controller;
            this.Action = Action;
            this.ParameterValue = ParaeterValue;


        }

        public static LeetCodeViewModel FindModel(int inId)
        {
            string fileName = "Leetcode.txt";
            var lines = System.IO.File.ReadLines(fileName).Skip(1);
            LeetCodeViewModel lcvm = new LeetCodeViewModel();
            List<LeetCodeViewModel> leetcodeModels = new List<LeetCodeViewModel>();
            foreach (var line in lines)
            {
                string[] leetObject = line.Split(";");
                if (Int32.Parse(leetObject[0]) == inId)
                {
                 lcvm  = new LeetCodeViewModel
                 {
                    
                    Id = Int32.Parse(leetObject[0]),
                    Name = leetObject[1],
                    Type = leetObject[2],
                    Action = leetObject[3],
                    Controller = leetObject[4],
                    ParameterValue = Int32.Parse(leetObject[5]),
                    DescriptionHref = leetObject[6],
                
                 };
                }

            }
            return lcvm;
            }

        public LeetCodeViewModel()
        {

        }

        // public static List<LeetCodeViewModel> PopulateLeetCodeModel()
        //{
      
        //        string[] leetObject = line.Split(";");
        //        LeetCodeViewModel leetCodeModel = new LeetCodeViewModel();
        //        Id = Int32.Parse(leetObject[0]);
        //        leetCodeModel.Name = leetObject[1];
        //        leetCodeModel.type = leetObject[2];
        //        leetCodeModel.Action = leetObject[3];
        //        leetCodeModel.Controller = leetObject[4];
        //        leetCodeModel.ParameterValue = Int32.Parse(leetObject[5]);
        //        leetCodeModel.descriptionHref = leetObject[6];
        //        // Name;Type;Action;Controller;parameter;href
        //        leetcodeModels.Add(leetCodeModel);
        //    }
        //    return leetcodeModels;
        //}

        // }

        // public 
    }
}
