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
        return View["result.cshtml"];
      };
    }
  }
}
