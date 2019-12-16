using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaClassLibrary
{
    public interface IFirma
    {
        #region Firma
        string FirmaNavn { get; }
        #endregion

        #region Car
        int AddCar(string NumberPlate, bool IsCarWashed, double RentPrice, string Brand, string Model, string Color, int Seats);
        List<Car> GetAllCars();
        int GetCarByID(int CarID);
        double ReturnCarRentPrice(int CarID);
        #endregion

        #region Customer
        int AddCustomer(string CustomerName, double CustomerSaldo);
        string AddAmountToCustomer(int CustomerID, double Amount);
        Customer ReturnCustomerAsObject(int CustomerID);
        int GetCustomerByID(int CustomerID);
        List<Customer> GetAllCustomers();
        #endregion

        #region Reservation
        int CreateReservation(DateTime ReservedFrom, DateTime ReservedTo, int ReservedCarID, int CustomerID);
        List<Reservation> GetAllReservations();
        #endregion

    }
}
