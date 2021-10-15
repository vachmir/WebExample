using Microsoft.AspNetCore.Mvc;
using WebExample.DataAccess;
using WebExample.Models;

namespace WebExample.Controllers
{
    public class CarController : Controller
    {
        private ApplicationContext _context=null!;
         
        public CarController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: CarController
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return RedirectToAction("Create");
        }
       
    }
}
