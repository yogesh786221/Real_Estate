using Microsoft.AspNetCore.Mvc;
using WEBSITE.Models;
using WEBSITE.Services;

namespace WEBSITE.Controllers
{
    public class PriceController : Controller
    {
        private readonly EmailService _emailService;

        public PriceController(EmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpGet("/Home/Price")]
        public IActionResult Price()
        {
            var model = new PriceModel();
            return View(model);
        }

        [HttpGet]
        public ActionResult BookingMesg()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> PriceForm(PriceModel model)
        {
            if (ModelState.IsValid)
            {
                var body = $"Name: {model.FullName}\nEmail: {model.Email}\nPhone: {model.Phone} \nProject: {model.Project} \nMessage: {model.Message}";
                await _emailService.SendEmailAsync("gaurbrothersassociate@gmail.com", model.Message!, body);
                return RedirectToAction("BookingMesg");
            }
            return View("Price", model);
        }
    
}
}
