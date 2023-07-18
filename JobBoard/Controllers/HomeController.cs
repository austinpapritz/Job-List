using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index( string name )
    {
      JobOpening newJobOpening = new JobOpening( name );
      return View( newJobOpening );
    }
    

    [Route("/form")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
