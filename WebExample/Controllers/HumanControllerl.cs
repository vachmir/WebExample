using Microsoft.AspNetCore.Mvc;
using WebExample.Models;

namespace WebExample.Controllers
{
    public class HumanController : Controller
    {
        private readonly ILogger<HumanController> _logger;

        public HumanController(ILogger<HumanController> logger)
        {
            _logger = logger;
        }

        public IActionResult HumanData(Human human)
        {
            int humanId = human.Id;
            string? name = human.Name;
            string? gender = human.Gender;
            string? email = human.Email;
            string? city = human.City;

            return View();
        }

    }
}
