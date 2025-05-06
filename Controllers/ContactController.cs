using Microsoft.AspNetCore.Mvc;
using WEBSITE.Models;
using WEBSITE.Services;

namespace WEBSITE.Controllers
{
    public class ContactController : Controller
    {
        private readonly EmailService _emailService;

        public ContactController(EmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpGet]
       public IActionResult Contact()
        {
            var model = new ContactFormModel();
            return View(model);
        }
        [HttpGet]
        public ActionResult ThankYou()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = $"Name: {model.Name}\nEmail: {model.Email}\nSubject: {model.Subject}\nMessage: {model.Message}";
                await _emailService.SendEmailAsync("gaurbrothersassociate@gmail.com", model.Subject!, body);
                return RedirectToAction("ThankYou");
            }

            return RedirectToAction("~/Views/Home/Contact.cshtml", model); 
        }
    
}
}
