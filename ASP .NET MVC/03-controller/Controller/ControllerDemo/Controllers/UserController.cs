using Microsoft.AspNetCore.Mvc;

namespace ControllerDemo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details (int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id invalide");
            }

            if (id > 100)
            {
                return NotFound();
            }

            return View();

        }


        public IActionResult GetUserJson (int id)
        {
            var User = new
            {
                Id = id,
                nom = "dupont",
                email = "dupont@mail.com"
            };

            return Json(User);
        }


        public IActionResult CreateUser ()
        {

            return RedirectToAction("Index");
        }


        public IActionResult AdminPanel(int? id)
        {

            if (id != 0) return Forbid();

            return View();

        }
    }
}

