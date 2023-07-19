using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class DetailsController : Controller
{
  [HttpGet("/job/{id}")]
  public ActionResult Details(int id)
  {
    JobOpening job = JobOpening.GetJobById(id);
    return View(job);
  }
}