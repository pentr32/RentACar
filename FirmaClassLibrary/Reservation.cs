using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaClassLibrary
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime ReservedFrom { get; set; }
        public DateTime ReservedTo { get; set; }
        public int ReservedCarID { get; set; }
        public int CustomerID { get; set; }

        public Reservation(int ReservationID, DateTime ReservedFrom, DateTime ReservedTo, int ReservedCarID, int CustomerID)
        {
            this.ReservationID = ReservationID;
            this.ReservedFrom = ReservedFrom;
            this.ReservedTo = ReservedTo;
            this.ReservedCarID = ReservedCarID;
            this.CustomerID = CustomerID;
        }
    }
}
