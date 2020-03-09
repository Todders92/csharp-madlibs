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
     public ActionResult Letter() {
      MadLibVariable newMadLib = new MadLibVariable();
      return View(newMadLib);
    }
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/funnyform")]
    public ActionResult FunnyForm()
    {
      MadLibVariable newMadLib = new MadLibVariable();
      return View(newMadLib);
    }

  }
}