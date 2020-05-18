using Microsoft.AspNetCore.Mvc;
using Madlib.models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Letter()
    {
     MadVariable myMadlib = new MadVariable();
      myMadlib.noun1 = "noun1";
      myMadlib.noun2 = "noun2";
      myMadlib.verb1 = "verb1";
      myMadlib.verb2 = "verb2";
      return View(myMadlib);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult Postcard(string noun1, string noun2, string verb1, string verb2)
    {
      MadVariable myMadlib = new MadVariable();
      myMadlib.noun1 = noun1;
      myMadlib.noun2 = noun2;
      myMadlib.verb1 = verb1;
      myMadlib.verb2 = verb2;
      return View(myMadlib);
    }

  }
}