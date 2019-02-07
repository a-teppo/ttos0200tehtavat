using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Vehicle
    {
        public string lause;
        public int laskuri;
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        //constructor
        public Vehicle(string name, int speed, int tyres)
        {
            Name = name;
            Speed = speed;
            Tyres = tyres;
        }
        //methods
        public void PrintData()
        {
            Console.WriteLine("Auton Nimi: {0}, Nopeus: {1} ja Renkaat {2}", Name, Speed, Tyres);
        }
        public string ToString(string name, int speed, int tyres)
        {
            
            lause = Name +Speed + Tyres;
            laskuri = lause.Length;
            return lause;
        }

    }
}
