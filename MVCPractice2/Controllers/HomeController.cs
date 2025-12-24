using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace MVCPractice2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}