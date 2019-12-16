using FirmaClassLibrary;

namespace NewRentCar.Models
{
    public class CarModel
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }
        public string NumberPlate { get; set; }
        public bool IsCarWashed { get; set; }
        public double RentPrice { get; set; }
    }
}
