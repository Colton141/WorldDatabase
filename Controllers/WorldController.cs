using Microsoft.AspNetCore.Mvc;
using World.Models;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace World.Controllers
{
  public class WorldController : Controller
  {

    // [HttpGet("/world/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Counter counter = Counter.Find(id);
    //   return View(counter);
    // }

    [HttpGet("/country")]
    public ActionResult Index()
    {
        List<Country> allCounters = Country.GetAll();
        return View(allCounters);
    }
    [HttpGet("/country/population")]
    public ActionResult Population()
    {
      List<Country> allcountries = Country.GetByPopulation();
      return View("Index", allcountries);
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
