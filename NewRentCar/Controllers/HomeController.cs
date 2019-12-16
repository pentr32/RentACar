using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirmaClassLibrary;
using NewRentCar.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NewRentCar.Controllers
{
    public class HomeController : Controller
    {
        private IFirma _firmarepos;

        public HomeController(IFirma firma)
        {
            _firmarepos = firma;
        }

        public IActionResult Index()
        {
            ViewBag.navn = _firmarepos.FirmaNavn;
            return View();
        }

        [HttpGet]
        public IActionResult AddNewCar(string NumberPlate, bool IsCarWashed, double RentPrice, string Brand, string Model, string Color, int Seats)
        {
            if (string.IsNullOrEmpty(NumberPlate))
            {
                ModelState.AddModelError(nameof(NumberPlate), "Du skal indtaste nummerplade");
            }

            if (ModelState.IsValid)
            {
                CarModel newCar = new CarModel()
                {
                    NumberPlate = NumberPlate,
                    IsCarWashed = IsCarWashed,
                    RentPrice = RentPrice,
                    Brand = Brand,
                    Model = Model,
                    Color = Color,
                    Seats = Seats,
                    CarID = _firmarepos.AddCar(NumberPlate, IsCarWashed, RentPrice, Brand, Model, Color, Seats),
                };
                
                return View("CarConfirm", newCar);
            }

            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult AddNewCar(CarModel car)
        {
            _firmarepos.AddCar(car.NumberPlate, car.IsCarWashed, car.RentPrice, car.Brand, car.Model, car.Color, car.Seats);
            return View();
        }

        [HttpGet]
        public IActionResult AddNewCustomer(string CustomerName, double CustomerSaldo)
        {
            if (string.IsNullOrEmpty(CustomerName))
            {
                ModelState.AddModelError(nameof(CustomerName), "Du skal indtaste dit navn");
            }

            if (ModelState.IsValid)
            {
                CustomerModel newCustomer = new CustomerModel()
                {
                    CustomerName = CustomerName,
                    CustomerSaldo = CustomerSaldo,
                    CustomerID = _firmarepos.AddCustomer(CustomerName, CustomerSaldo)
            };
                
                return View("CustomerConfirm", newCustomer);
            }

            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult AddNewCustomer(CustomerModel customer)
        {
            _firmarepos.AddCustomer(customer.CustomerName, customer.CustomerSaldo);
            return View();
        }

        [HttpGet]
        public ViewResult CreateNewReservation()
        {
            ReservationModel res = new ReservationModel()
            {
                AllCustomers = new SelectList(_firmarepos.GetAllCustomers(), "CustomerID", "CustomerID"),
                AllCars = new SelectList(_firmarepos.GetAllCars(), "CarID", "CarID")
            };
            return View(res);
        }

        [HttpPost]
        public ViewResult CreateNewReservation(ReservationModel reservation)
        {
            _firmarepos.CreateReservation(reservation.ReservedFrom, reservation.ReservedTo, reservation.SelectedCarID, reservation.SelectedCustomerID);
            return View(nameof(ReservationConfirm));
        }

        public ViewResult CarConfirm()
        {
            return View();
        }

        public ViewResult CustomerConfirm()
        {
            return View();
        }

        public ViewResult ReservationConfirm()
        {
            return View();
        }
    }
}