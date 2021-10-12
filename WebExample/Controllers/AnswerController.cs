using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebExample.Models;
using WebExample.ViewModels;

namespace WebExample.Controllers
{
    public class AnswerController : Controller
    {
        private readonly IConfiguration configuration;
        //string dbConnection = _configuration.GetConnectionString("Default");
        public AnswerController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public IActionResult Result()
        {
            string defaultConn = this.configuration.GetConnectionString("Սկզբնական կապուղի");
            //string connectionString = "Data Source = VACHMIRLAPTOP; Initial Catalog = DeleteMe; Integrated Security = True; ";
            ViewBag.DbConnectioString = defaultConn; //To check the presence of Connection String

            using (var connection = new SqlConnection(defaultConn))
            {
                connection.Open();
                var command = new SqlCommand("Select * From TestPerson", connection);

                SqlDataReader reader = command.ExecuteReader();

                List<TestPerson> testPerson = new List<TestPerson>();
                while (reader.Read())
                {
                    testPerson.Add(new TestPerson
                    {
                        PersonId = Convert.ToInt32(reader["PersonId"]),
                        LastName = reader["LastName"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        FkcarId = Convert.ToInt32(reader["FkcarId"])
                    }); 
                }
                ViewBag.SelectedTestPersonsFromDb = testPerson;
            }

            using (var connection = new SqlConnection(defaultConn))
            {
                connection.Open();
                var command = new SqlCommand("Select * From TestCar", connection);

                SqlDataReader reader = command.ExecuteReader();

                List<TestCar> testCar = new List<TestCar>();
                while (reader.Read())
                {
                    testCar.Add(new TestCar
                    {
                        CarId = Convert.ToInt32(reader["CarId"]),
                        Model=reader["Model"].ToString()

                    });
                }
                ViewBag.SelectedTestCarsFromDb = testCar;
            }

            using (var connection= new SqlConnection(defaultConn))
            {
                connection.Open();
                var command = new SqlCommand("SELECT TestPerson.LastName, TestPerson.FirstName, TestCar.Model" +
                                            " FROM TestPerson, TestCar WHERE TestPerson.FKCarId = TestCar.CarId", connection);

                SqlDataReader reader = command.ExecuteReader();

                List<CarOwner> carOwners = new List<CarOwner>();
                while (reader.Read())
                {
                    carOwners.Add(new CarOwner
                    {
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        CarModel = reader["Model"].ToString()
                    }) ;
                }
                ViewBag.SelectedFromCarOwner = carOwners;
            }
            return View();
        }

        // GET: AnswerController
        public IActionResult Index()
        {
            return View();
        }

        // GET: AnswerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnswerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnswerController/Create
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

        // GET: AnswerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnswerController/Edit/5
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

        // GET: AnswerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnswerController/Delete/5
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
