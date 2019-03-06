using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Auto
    {
        //member fields
        private const int maxTyres = 4;
        private List<Tyre> tyres = new List<Tyre>();
        //properties
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int TyreCount
        {
            get
            {
                return tyres.Count;
            }
        }
        public List<Tyre> Tyres { get { return tyres; } }
        //constructor
        //methods
        public bool AddTyre(Tyre tyre)
        {
            if (tyres.Count < maxTyres)
            {
                tyres.Add(tyre);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ShowData()
        {
            string retval = $"{Manufacturer} {Model} :ssa on {TyreCount} rengasta: \n";
            foreach (var item in tyres)
            {
                retval += $"- " + item.ToString() + "\n";
            }
            return retval;
        }
    }
    public class Tyre
    {
        //properties
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
        //methods

        public override string ToString()
        {
            return $"{Manufacturer} {Model} {Size}";
        }
    }
}
