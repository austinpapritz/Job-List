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

  [HttpGet("/jobs/new")]
  public ActionResult CreateForm()
  {
    return View();
  }

  [HttpPost("/jobs")]
  public ActionResult Create(string name, string email, string phonenumber, string gender)
  {
    JobOpening newJobOpening = new JobOpening(name, email, phonenumber, gender);
    List<JobOpening> allJobOpenings = JobOpening.GetAll();
    return RedirectToAction("Index", allJobOpenings);
  }

  [HttpPost("/jobs/delete")]
  public ActionResult Destroy()
  {
    JobOpening.ClearAll();
    List<JobOpening> allJobOpenings = JobOpening.GetAll();
    return View("Index", allJobOpenings);
  }
  
}