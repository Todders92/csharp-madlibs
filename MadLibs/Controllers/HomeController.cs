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

    [Route("/madlib")]
    public ActionResult MadLib(string person1, string person2, string animal, string exclamation, string verb, string noun)
    {
      MadLibVariable newMadLib = new MadLibVariable();
      newMadLib.Person1 = person1;
      newMadLib.Person2 = person2;
      newMadLib.Animal = animal;
      newMadLib.Exclamation = exclamation;
      newMadLib.Verb = verb;
      newMadLib.Noun = noun;
      return View(newMadLib);
    }

  }
}