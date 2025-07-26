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

    public IActionResult Sort(List<int> data,int id)
    {
        // https://stackoverflow.com/questions/8251951/call-a-method-dynamically-based-on-some-other-variable
        var lcvm = LeetCodeViewModel.FindModel(id);
        string methodName = lcvm.Name;
        var type = typeof(ListModel);
        var method = type.GetMethod("TwoSum");
        // https://stackoverflow.com/questions/28625632/reflection-invoking-a-method-with-listclass-parameter/28626004#28626004
        var obj = new Object();
        object classInstance = Activator.CreateInstance(type, null);
        object[] parameters = new object[] { data};
       var listReturn = (ReturnModel)method.Invoke(classInstance,new[] { data });
        var target = (listReturn.retModel).GetType();
        dynamic origMsg = (dynamic)Convert.ChangeType(listReturn.retModel,target );
       var check = origMsg.GetType() == typeof(List<int>);
        //`var tsu = typeof(origMsg);
        var tyu = origMsg.GetType();
        var origs = (listReturn.retModel).GetType();
        var origs2 = (new List<int>{ 123}).GetType();
        Type hfg = listReturn.returnType;
       
        //var srt = ()listReturn.retModel;
        //var typesr = typeof(hfg);
        //dynamic origMsg = (dynamic)Convert.ChangeType(obj, type);
        //List<int> numbers = ListHelperClass.ReturnInList(fc, null);
        //numbers.Sort();
        return View("");
    }
}
