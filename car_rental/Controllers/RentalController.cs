using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using car_rental.Models;

namespace car_rental.Controllers
{
    public class RentalController : Controller
    {
        private List<Car> cars;
        private List<Customer> customers;
        private List<RentalAgreement> rentalAgreements;

        public RentalController()
        {
            // Create cars
            cars = new List<Car>
            {
                new Car()
                {
                    RegistrationNumber = "AAA111",
                    Make = "company",
                    Model = "firstModel",
                    Color = "White"
                },
                new Car()
                {
                    RegistrationNumber = "BBB222",
                    Make = "company",
                    Model = "secondModel",
                    Color = "DarkGreen"
                },
                new Car()
                {
                    RegistrationNumber = "CCC333",
                    Make = "company2",
                    Model = "Model1",
                    Color = " Yellow"
                }
            };

            // Create Customer
            customers = new List<Customer>
            {
                new Customer()
                {
                    ID = 0,
                    Name = "i am customer",
                    Email = "example@email.com",
                    PhoneNumber = "01189998819991197253"
                }
            };

            // Create RentalAgreement
            rentalAgreements = new List<RentalAgreement>
            {
                new RentalAgreement()
                {
                    ID = 0,
                    Car = cars.First(),
                    Customer = customers.First(),
                    FromRentalTime = DateTime.Now,
                    ToRentalTime = DateTime.Now.AddHours(4)
                }
            };

        }

        // GET: Rental
        public ActionResult Index()
        {
            return View(cars);
        }
    }
}