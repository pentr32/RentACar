using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaClassLibrary
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public double CustomerSaldo { get; set; }
        public List<Reservation> CustomerReservation { get; set; }

        public Customer(int CustomerID, string CustomerName, double CustomerSaldo)
        {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
            this.CustomerSaldo = CustomerSaldo;
        }
    }
}
