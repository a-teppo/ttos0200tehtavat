using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUSI
{
    public abstract class Vehicle
    {
        //properties
        public abstract string Name { get; set; }
        public abstract string Model { get; set; }
        public abstract int ModelYear { get; set; }
        public abstract string Color { get; set; }

        //constructor
        // public Vehicle() { }

        //public Vehicle(string name, string model, int modelyear, string color)
        //{
        //    Name = name;
        //    Model = model;
        //    ModelYear = modelyear;
        //    Color = color;
        //}
    }
    public class Bike : Vehicle
    {
        //properties
        public override string Name { get; set; }
        public override string Model { get; set; }
        public override int ModelYear { get; set; }
        public override string Color { get; set; }
        public bool GearWheel { get; set; }
        public string GearName { get; set; }
        //constructor
        public Bike(string name, string model, int modelyear, string color)
        {
           Name = name;
            Model = model;
           ModelYear = modelyear;
            Color = color;
        }
        //methods
        public override string ToString()
        {
            return $"{Manufacturer} {Model} {Size}";
        }
    }

    public class Boat : Vehicle
    {
        public override string Name { get; set; }
        public override string Model { get; set; }
        public override int ModelYear { get; set; }
        public override string Color { get; set; }
        public string BoatType { get; set; }
        public int SeatCount { get; set; }
    }
    

}
