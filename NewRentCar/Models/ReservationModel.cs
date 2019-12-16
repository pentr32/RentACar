using FirmaClassLibrary;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace NewRentCar.Models
{
    public class ReservationModel
    {
        public int ReservationID { get; set; }
        public DateTime ReservedFrom { get; set; }
        public DateTime ReservedTo { get; set; }
        public int ReservedCarID { get; set; }
        public int CustomerID { get; set; }

        public SelectList AllCustomers { get; set; }
        public SelectList AllCars { get; set; }

        public int SelectedCustomerID { get; set; }
        public int SelectedCarID { get; set; }
    }
}
