using System.Collections.Generic;
using FirmaClassLibrary;

namespace NewRentCar.Models
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public double CustomerSaldo { get; set; }
        public List<ReservationModel> CustomerReservation { get; set; }
    }
}
