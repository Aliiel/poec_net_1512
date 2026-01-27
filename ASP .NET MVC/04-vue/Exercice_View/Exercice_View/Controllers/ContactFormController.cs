using Exercice_View.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exercice_View.Controllers
{
    public class ContactFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateContactForm()
        {
            ViewBag.Subjects = new List<SelectListItem>()
            {
                new SelectListItem { Value = "Question", Text = "Question"},
                new SelectListItem { Value = "Réclamation", Text = "Réclamation"},
                new SelectListItem { Value = "Suggestion", Text = "Suggestion"}
            };

            return View(new ContactForm());
        }

        [HttpPost]
        public IActionResult CreateContactForm(ContactForm ContactForm)
        {
            TempData["Success"] = "Votre contact a bien été enregistré !";
            return RedirectToAction("Index", "Home");
        }
    }
}
