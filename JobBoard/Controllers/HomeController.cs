using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

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
      // GetAll() job openings and send to View
      JobOpening newJobOpening = new JobOpening( name );
      return View( "Index", newJobOpening );
    }
  }
