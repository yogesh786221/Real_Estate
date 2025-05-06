using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WEBSITE.Models;

namespace WEBSITE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
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
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
       
        
       
        //public IActionResult Price()
        //{
        //    ViewBag.Success = false;
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Price(ContactFormModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Log or store model details here. You can also send an email.
        //        _logger.LogInformation("Contact form submitted: {@Model}", model);

        //        ViewBag.Success = true;
        //    }
        //    return View();
        //}

        public IActionResult Projects()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
