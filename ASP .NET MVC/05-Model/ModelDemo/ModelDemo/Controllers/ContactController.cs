using Microsoft.AspNetCore.Mvc;

namespace ModelDemo.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }


}
