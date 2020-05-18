using Microsoft.AspNetCore.Mvc;
using Madlib.models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Launch()
    {
      return View();
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult Madlib(string properNoun, string noun2, string verb1, string verb2, string adjective1)
    {
      MadVariable myMadlib = new MadVariable(properNoun, noun2, verb1, verb2, adjective1);
      return View(myMadlib);
    }

  }
}