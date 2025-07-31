using Microsoft.AspNetCore.Mvc;
using ResturauntViewing.Models.LeetCodeMethodModels;
using ResturauntViewing.Models.Models;
using System.Runtime.CompilerServices;
namespace ResturauntViewing.Controllers;

public class ListController : Controller
{
    //public IActionResult Sort(IFormCollection fc, IFormCollection fc2)
    //{
       
    //   List<int> numbers = ListHelperClass.ReturnInList(fc,null);
    //    numbers.Sort();
    //    return View("");
    //}

    public JsonResult Sort(List<int> data,int id,int? target)
    {
        // https://stackoverflow.com/questions/8251951/call-a-method-dynamically-based-on-some-other-variable
        var lcvm = LeetCodeViewModel.FindModel(id);
        string methodName = lcvm.Name;
        var type = typeof(ListQuestions);
        var method = type.GetMethod(lcvm.Name);
        // https://stackoverflow.com/questions/28625632/reflection-invoking-a-method-with-listclass-parameter/28626004#28626004
        object classInstance = Activator.CreateInstance(type, null);
        // var listReturn = (ReturnModel)method.Invoke(classInstance,new object[] { data,target });
        var listReturn = method.Invoke(classInstance, new object[] { data.ToArray(), target });
       // var targetType = (listReturn.retModel).GetType();
       // dynamic origMsg = (dynamic)Convert.ChangeType(listReturn.retModel,targetType );
       //var check = origMsg.GetType() == typeof(List<int>);
       // var tyu = origMsg.GetType();
        return Json(listReturn);
    }
}
