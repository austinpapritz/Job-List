using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    
    [HttpGet("/openings/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/openings")]
    public ActionResult Create(string name)
    {
      JobOpening newJobOpening = new JobOpening( name );
      List<JobOpening> allJobOpenings = JobOpening.GetAll();
      return View( "Index", allJobOpenings );
    }
  }
