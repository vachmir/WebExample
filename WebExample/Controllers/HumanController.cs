using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebExample.DataAccess;
using WebExample.Models;
using WebExample.ViewModels;

namespace WebExample.Controllers
{
    public class HumanController : Controller
    {
        readonly ApplicationContext _context;
       
        public HumanController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            CarsViewModel carsVM = new CarsViewModel();
            carsVM.Cars = _context.Cars.ToList();
            return View(carsVM);
        }

        [HttpPost]
        public IActionResult Create(Human human)
        {
            _context.Humans.Add(human);
            _context.SaveChanges();
            return RedirectToAction("Create");
        }
      
    }
}
