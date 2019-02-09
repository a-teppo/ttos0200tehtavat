using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.TTOS0200
{
    public  class Vehicle
    {
        //properties
        public  string Name { get; set; }
        public  string Model { get; set; }
        public int ModelYear { get; set; }
        public  string Color { get; set; }
    
        //constructor
        // public Vehicle() { }

        public Bike(string name, string model, int modelyear, string color)
        {
            Name = name;
            Model = model;
            ModelYear = modelyear;
            Color = color;
        }
        //methods
    }
    /*
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
    */
}
