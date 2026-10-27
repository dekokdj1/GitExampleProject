using ExtensionMethodExample.Extensions;
using ExtensionMethodExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace ExtensionMethodExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            int a = 5; //value type
            IntWrapper c = new IntWrapper { Additive = 5 }; // reference type //not static
            UpdateReference(c);
            UpdateValue(ref a);

            var b = Math.Abs(5); //static

            var y = Convert.ToInt16(200);



            string s = "Hello World";
            var x = s.ContainsSpecificString("Hello");
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        static void UpdateReference(IntWrapper b)
        {
            b.Additive += 30;
        }

        static void UpdateValue(ref int a)
        {
            a += 30;
        }
    }
}
