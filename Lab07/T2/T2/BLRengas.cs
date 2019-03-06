using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Kulkuneuvot
    { 
        
        private List<Rengas> renkaat = new List<Rengas>();
        //properties
        
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int TyreCount
        {
            get
            {
                return renkaat.Count;
            }
        }
        public List<Rengas> Renkaat { get { return renkaat; } }
        //methods
        public bool AddTyre4(Rengas rengas)
        {
            if (renkaat.Count < 4)
            {
                renkaat.Add(rengas);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddTyre2(Rengas rengas)
        {
            if (renkaat.Count < 2)
            {
                renkaat.Add(rengas);
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
            foreach (var item in renkaat)
            {
                retval += $"- " + item.ToString() + "\n";
            }
            return retval;
        }
    }
    public class Rengas
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
