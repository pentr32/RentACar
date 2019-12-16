using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaClassLibrary
{
    public class Brands
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }

        public Brands(string Brand, string Model, string Color, int Seats)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Color = Color;
            this.Seats = Seats;
        }
    }
}
