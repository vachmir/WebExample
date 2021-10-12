using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebExample.Models;

namespace WebExample.Controllers
{
    public class CarController : Controller
    {
        private readonly IConfiguration _logger;

        public CarController(IConfiguration logger)
        {
            _logger = logger;
        }

        // GET: CarController
       [HttpGet]
        public ActionResult CarData()
        {
            string defaultConn = _logger.GetConnectionString("Default");
            //string connectionString = "Data Source = VACHMIRLAPTOP; Initial Catalog = DeleteMe; Integrated Security = True; ";
            using (var connection = new SqlConnection(defaultConn))
            {
                return View();
            }
        }

      [HttpPost]
        public ActionResult CarData(Models.Car car)
        {
            ViewBag.Id = car.Id;
            ViewBag.Model = car.Model;
            ViewBag.SerialNumber = car.SerialNumber;

            return View("CarData");
        }

        // GET: CarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
