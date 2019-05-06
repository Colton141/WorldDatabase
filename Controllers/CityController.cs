using Microsoft.AspNetCore.Mvc;
using World.Models;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace World.Controllers
{
  public class CityController : Controller
  {

    // [HttpGet("/world/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Counter counter = Counter.Find(id);
    //   return View(counter);
    // }

    [HttpGet("/country/{code}")]
    public ActionResult Index(string code)
    {
        List<City> allCounters = City.GetAll(code);
        return View(allCounters);
    }


    // [HttpPost("/game")]
    // public ActionResult Create(string compare, string to)
    // {
    //     if(Regex.IsMatch(compare, @"^[a-zA-Z]+$") == true)
    //     {
    //       Counter theCounter = new Counter(compare, to);
    //     }
    //     return RedirectToAction("Index");
    // }

  }
}
