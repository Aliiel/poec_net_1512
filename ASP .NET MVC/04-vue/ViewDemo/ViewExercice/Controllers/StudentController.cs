using Microsoft.AspNetCore.Mvc;
using ViewExercice.Models;

namespace ViewExercice.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var Students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    FirstName = "Jean",
                    LastName = "Paul",
                    Note = 18
                },
                new Student
                {
                    Id = 1,
                    FirstName = "Paul",
                    LastName = "Jacques",
                    Note = 14
                },
                new Student
                {
                    Id = 1,
                    FirstName = "Jacques",
                    LastName = "Pierre",
                    Note = 9
                },
                new Student
                {
                    Id = 1,
                    FirstName = "Pierre",
                    LastName = "Marcel",
                    Note = 11
                },
                new Student
                {
                    Id = 1,
                    FirstName = "Marcel",
                    LastName = "Charles",
                    Note = 16
                }
            };
            return View(Students);
        }
    }
}
