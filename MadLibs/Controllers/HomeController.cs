using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult SplashPage() {
    return View();
    }
    [Route("/form1")]
    public ActionResult Form1() { return View(); }

    [Route("form2")]
    public ActionResult Form2() { return View(); }

    [Route("/madlib1")]
    public ActionResult MadLib1(string person1, string person2, string animal, string exclamation, string noun1, string noun2, string noun3, string noun4, string noun5, string adjective1, string adjective2, string adjective3, string adjective4, string adjective5, string verb1, string verb2, string verb3, string adverb1)
    {
      MadLibVariable newMadLib = new MadLibVariable();

      newMadLib.Person1 = person1;
      newMadLib.Person2 = person2;
      newMadLib.Animal = animal;
      newMadLib.Exclamation = exclamation;
      newMadLib.Noun1 = noun1;
      newMadLib.Noun2 = noun2;
      newMadLib.Noun3 = noun3;
      newMadLib.Noun4 = noun4;
      newMadLib.Noun5 = noun5;
      newMadLib.Adjective1 = adjective1;
      newMadLib.Adjective2 = adjective2;
      newMadLib.Adjective3 = adjective3;
      newMadLib.Adjective4 = adjective4;
      newMadLib.Adjective5 = adjective5;
      newMadLib.Verb1 = verb1;
      newMadLib.Verb2 = verb2;
      newMadLib.Verb3 = verb3;
      newMadLib.Adverb1 = adverb1;
      return View(newMadLib);
    }

    [Route("/madlib2")]
    public ActionResult MadLib2(string person1, string person2, string animal, string exclamation, string noun1, string noun2, string noun3, string noun4, string noun5, string adjective1, string adjective2, string adjective3, string adjective4, string adjective5, string verb1, string verb2, string verb3, string adverb1)
    {
      MadLibVariable newMadLib = new MadLibVariable();
      newMadLib.Person1 = person1;
      newMadLib.Person2 = person2;
      newMadLib.Animal = animal;
      newMadLib.Exclamation = exclamation;
      newMadLib.Noun1 = noun1;
      newMadLib.Noun2 = noun2;
      newMadLib.Noun3 = noun3;
      newMadLib.Noun4 = noun4;
      newMadLib.Noun5 = noun5;
      newMadLib.Adjective1 = adjective1;
      newMadLib.Adjective2 = adjective2;
      newMadLib.Adjective3 = adjective3;
      newMadLib.Adjective4 = adjective4;
      newMadLib.Adjective5 = adjective5;
      newMadLib.Verb1 = verb1;
      newMadLib.Verb2 = verb2;
      newMadLib.Verb3 = verb3;
      newMadLib.Adverb1 = adverb1;
      return View(newMadLib);
    }

  }
}