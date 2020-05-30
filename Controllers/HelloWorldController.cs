using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcCard.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //"Message" and "numTimes" come from the query string in the address bar
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}