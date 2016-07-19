using Nancy;
using System;
using System.Collections.Generic;
using CoinList.Objects;
namespace CoinList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/result"] = _ => {
        double inputNumber=Double.Parse(Request.Query["newNumber"]);
        Coin myCoin = new Coin(Request.Query["newNumber"]);
        return View["result.cshtml",myCoin];
      };
    }
  }
}
