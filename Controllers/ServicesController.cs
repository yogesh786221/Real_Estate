using Microsoft.AspNetCore.Mvc;
using WEBSITE.Models;
using WEBSITE.Services;

namespace WEBSITE.Controllers
{
    public class ServicesController : Controller
    {
        private readonly EmailService _emailService;

        public ServicesController(EmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpGet("/Home/ResidentialSales")]
        public IActionResult ResidentialSales()
        {
            return View();
        }
        [HttpGet]
        public ActionResult BookingMesg()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Residential(ResidentialModel model)
        {
            if (ModelState.IsValid)
            {
                var body = $"Name: {model.FullName}\nPhone Number: {model.PhoneNumber}\nPreferred Date: {model.PreferredDate}";
                await _emailService.SendEmailAsync("gaurbrothersassociate@gmail.com", model.FullName!, body);
                return RedirectToAction("BookingMesg");
            }

            return View("ResidentialSales", model);
        }
        [HttpGet("/Home/CommercialLeasing")]
        public IActionResult CommercialLeasing()
        {
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> Commercial(CommercialModel model)
        {
            if (ModelState.IsValid)
            {
                var body = $"Name: {model.FullName}\nPhone Number: {model.PhoneNumber}\nPreferred Date: {model.PreferredDate}";
                await _emailService.SendEmailAsync("gaurbrothersassociate@gmail.com", model.FullName!, body);
                return RedirectToAction("BookingMesg");
            }

            return View("CommercialLeasing", model);
        }
        [HttpGet("/Home/StudioInvestments")]
        public IActionResult StudioInvestments()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Studio(StudioInvestmentsModel model)
        {
            if (ModelState.IsValid)
            {
                var body = $"Name: {model.FullName}\nPhone Number: {model.PhoneNumber}\nPreferred Date: {model.PreferredDate}";
                await _emailService.SendEmailAsync("gaurbrothersassociate@gmail.com", model.FullName!, body);
                return RedirectToAction("BookingMesg");
            }

            return View("StudioInvestments", model);
        }

        [HttpGet("/Home/LegalAdvisory")]
        public IActionResult LegalAdvisory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Legal(LegalAdvisoryModel model)
        {
            if (ModelState.IsValid)
            {
                var body = $"Name: {model.FullName}\nPhone Number: {model.PhoneNumber}\nPreferred Date: {model.PreferredDate}";
                await _emailService.SendEmailAsync("gaurbrothersassociate@gmail.com", model.FullName!, body);
                return RedirectToAction("BookingMesg");
            }
            return View("LegalAdvisory", model);
        }
    }
}
