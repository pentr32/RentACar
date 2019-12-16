using System;
using System.Collections.Generic;

namespace FirmaClassLibrary
{
    public class Firma : IFirma
    {
        public string FirmaNavn { get; }
        int carIDTæller;
        int customerIDTæller;
        int reservationIDTæller;
        List<Car> cars;
        List<Customer> customers;
        List<Reservation> reservations;

        /// <summary>
        /// Constructor der modtag et firmanavn og oprette forskellige lister.
        /// </summary>
        /// <param name="FirmaNavn">Firmas navn</param>
        public Firma(string FirmaNavn)
        {
            this.FirmaNavn = FirmaNavn;
            cars = new List<Car>();
            customers = new List<Customer>();
            reservations = new List<Reservation>();
        }

        /// <summary>
        /// Metod der tilføje en ny bil
        /// </summary>
        /// <param name="NumberPlate">Navn på nummerplade</param>
        /// <param name="IsCarWashed">True eller false</param>
        /// <param name="RentPrice">Prisen på lån</param>
        /// <param name="Brand">Brands name</param>
        /// <param name="Model">Models name</param>
        /// <param name="Color">Colors name</param>
        /// <param name="Seats">Amount of seats</param>
        /// <returns></returns>
        public int AddCar(string NumberPlate, bool IsCarWashed, double RentPrice, string Brand, string Model, string Color, int Seats)
        {
            Brands brand = new Brands(Brand, Model, Color, Seats);
            cars.Add(new Car(++carIDTæller, brand, NumberPlate, IsCarWashed, RentPrice));
            return carIDTæller;
        }

        /// <summary>
        /// Metod der returnere alle bilerne
        /// </summary>
        /// <returns></returns>
        public List<Car> GetAllCars()
        {
            return cars;
        }

        /// <summary>
        /// Metod der finder en bil efter ID
        /// </summary>
        /// <param name="CarID">Cars ID</param>
        /// <returns></returns>
        public int GetCarByID(int CarID)
        {
            Car FundetCar = cars.Find(car => car.CarID == CarID);
            return FundetCar.CarID;
        }

        public double ReturnCarRentPrice(int CarID)
        {
            Car FundetCar = cars.Find(car => car.CarID == CarID);
            return FundetCar.RentPrice;
        }

        /// <summary>
        /// Metod der oprette en ny kunde
        /// </summary>
        /// <param name="CustomerName">Customers name</param>
        /// <param name="CustomerSaldo">Customers amount</param>
        /// <returns></returns>
        public int AddCustomer(string CustomerName, double CustomerSaldo)
        {
            customers.Add(new Customer(++customerIDTæller, CustomerName, CustomerSaldo));
            return customerIDTæller;
        }

        /// <summary>
        /// Metod der indsætte penge på en specifik kontoen
        /// </summary>
        /// <param name="CustomerID">Kontoens ID</param>
        /// <param name="Amount">Antal penge</param>
        /// <returns></returns>
        public string AddAmountToCustomer(int CustomerID, double Amount)
        {
            foreach(Customer hverCustomer in customers)
            {
                if(hverCustomer.CustomerID == CustomerID)
                {
                    hverCustomer.CustomerSaldo += Amount;
                    return string.Format("Penge blev indsæt på kontoen {0}", hverCustomer.CustomerName);
                }
            }
            return "Kontoen blev ikke fundet";
        }

        public Customer ReturnCustomerAsObject(int CustomerID)
        {
            Customer FundetCustomer = customers.Find(customer => customer.CustomerID == CustomerID);
            return FundetCustomer;
        }

        /// <summary>
        /// Metod der returnere kontoens ID
        /// </summary>
        /// <param name="CustomerID">kontoens ID</param>
        /// <returns></returns>
        public int GetCustomerByID(int CustomerID)
        {
            Customer FundetCustomer = customers.Find(customer => customer.CustomerID == CustomerID);
            return FundetCustomer.CustomerID;
        }

        /// <summary>
        /// Metod der returnere alle kunderne
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        /// <summary>
        /// Metod der oprette ny reservation til specifik carID
        /// </summary>
        /// <param name="ReservedFrom">Start dato</param>
        /// <param name="ReservedTo">Slut dato</param>
        /// <param name="ReservedCarID">CarID som findes allerede i listen</param>
        /// <returns></returns>
        public int CreateReservation(DateTime ReservedFrom, DateTime ReservedTo, int ReservedCarID, int CustomerID)
        {
            foreach(Car hverCar in cars)
            {
                if(hverCar.CarID == ReservedCarID)
                {
                    foreach (Customer hverCustomer in customers)
                    {
                        if (hverCustomer.CustomerID == CustomerID)
                        {
                            Reservation res = new Reservation(++reservationIDTæller, ReservedFrom, ReservedTo, hverCar.CarID, hverCustomer.CustomerID);
                            reservations.Add(res);
                            hverCustomer.CustomerReservation.Add(res);
                            hverCustomer.CustomerSaldo -= hverCar.RentPrice;
                            return res.ReservationID;
                        }
                    }                  
                }
            }
            return 0;
        }

        /// <summary>
        /// Metod der returnere alle reservationer
        /// </summary>
        /// <returns></returns>
        public List<Reservation> GetAllReservations()
        {
            return reservations;
        }
    }
}
