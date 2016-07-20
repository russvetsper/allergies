using Nancy;
using System;
using System.Collections.Generic;
using Allergies.Objects;
namespace AllergyList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/result"]= _ =>{
        Allergy myAllergy = new Allergy(Request.Query["newNumber"]);
        return View["result.cshtml",myAllergy];
      };
    }
  }
}
