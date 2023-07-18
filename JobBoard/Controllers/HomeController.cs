using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

  public class HomeController : Controller
  {
    [Route("/")] // Get
    public ActionResult Index( string name )
    {
      JobOpening newJobOpening = new JobOpening( name );
      return View( newJobOpening );
    }
    
    [Route("/openings/new")] // Get
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/openings")] // Post
    public ActionResult Create(string name)
    {
      JobOpening newJobOpening = new JobOpening( name );
      return View( "Index", newJobOpening );
    }
  }
