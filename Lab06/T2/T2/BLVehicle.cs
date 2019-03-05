using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, ModelYear: {ModelYear}, Color: {Color}";
        }
    }

    public class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearNames { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"GearWheels: {GearWheels}, GearNames: {GearNames} ";
        }
    }

    public class Boat : Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"SeatCount: {SeatCount}, BoatType: {BoatType} ";
        }
    }
}
