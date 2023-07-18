using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<JobOpening> allJobOpenings = JobOpening.GetAll();
      return View(allJobOpenings);
    }
    
    [HttpGet("/openings/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/openings")]
    public ActionResult Create(string name, string email, int idnumber, string phonenumber, string gender)
    {
      JobOpening newJobOpening = new JobOpening( name, email, idnumber, phonenumber, gender);
      List<JobOpening> allJobOpenings = JobOpening.GetAll();
      return RedirectToAction("Index", allJobOpenings);
    }
  }