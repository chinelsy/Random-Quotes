using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomQuotes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RandomQuotes.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //var quote = new GenerateQuotes().GetRandomQuotes();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
