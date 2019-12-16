using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaClassLibrary
{
    public class Car
    {
        public int CarID { get; set; }
        public Brands CarBrand { get; set; }
        public string NumberPlate { get; set; }
        public bool IsCarWashed { get; set; }
        public double RentPrice { get; set; }

        public Car(int CarID, Brands CarBrand, string NumberPlate, bool IsCarWashed, double RentPrice)
        {
            this.CarID = CarID;
            this.CarBrand = CarBrand;
            this.NumberPlate = NumberPlate;
            this.IsCarWashed = IsCarWashed;
            this.RentPrice = RentPrice;
        }
    }
}
