using Microsoft.AspNetCore.Mvc;
using JobOpening.Models;

namespace JobOpening.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public string Index()
    {
      return "Karate";
    }

  }
}