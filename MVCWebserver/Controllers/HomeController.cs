using Microsoft.AspNetCore.Mvc;

namespace MVCWebserver.Controllers;

public class HomeController : Controller
{
    //Denna metod returnerar en vy (HTML-sida) som ligger i mappen Views/Home/Index.cshtml
    public IActionResult Index()
    {
        return View();
    }

    //Denna metod returnerar en vy (HTML-sida) som ligger i mappen Views/Home/About.cshtml
    public IActionResult About()
    {
        //ViewData är en dictionary som kan användas för att skicka data till vyn
        ViewData["Time"] = DateTime.Now.ToString("HH:mm:ss");
        return View();
    }

    //Denna metod returnerar en vy (HTML-sida) som ligger i mappen Views/Home/Model.cshtml
    public IActionResult Model()
    {
        List<string> names = new List<string> { "Adam", "Bertil", "Cesar" };
        return View(names);
    }
}
