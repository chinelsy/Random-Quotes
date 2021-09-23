using Microsoft.AspNetCore.Mvc;
using RandomQuotes.Models;
using System.Diagnostics;

namespace RandomQuotes.Controllers
{
    public class HomeController : Controller
    {
        private readonly object Storequotes;

        public ViewResult Index()
        {
            return View();
        }

        public IActionResult Privacy() 
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
