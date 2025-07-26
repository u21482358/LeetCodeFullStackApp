using ResturauntViewing.Models.Models;

namespace ResturauntViewing.Models.LeetCodeMethodModels
{
    public class ListModel
    {

        public object TwoSum(List<int> List1)
        {
            int a = 0;
            object obj = (List1, "List<int>");


            Type type = Type.GetType("List<int>");
            ReturnModel returnModel = new ReturnModel();
            Type t = typeof(List<int>);
            returnModel.returnType = t;
            returnModel.strType = List1.GetType().FullName;
            Type mytype = Type.GetType("System.Collections.Generic.List<int>"); // give all namespaces?
            returnModel.retModel = List1;
           // dynamic origMsg = (dynamic)Convert.ChangeType(obj, type);
            return returnModel; // also return type as object. to cast back
        }
    }
}
