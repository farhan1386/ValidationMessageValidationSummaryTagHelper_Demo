using Microsoft.AspNetCore.Mvc;
using ValidationMessageValidationSummaryTagHelper_Demo.Models;

namespace ValidationMessageValidationSummaryTagHelper_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
