using Microsoft.AspNetCore.Mvc;
using Uppfinaren_1._0.Models.Data;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return View(); 
    }

}