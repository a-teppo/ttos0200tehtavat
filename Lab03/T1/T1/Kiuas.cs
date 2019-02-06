using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Kiuas
    {
        // field variables
        // properties
        public string Merkki {get; set;}
        public int Lämpötila {get; set;}
        public int Kosteus {get; set;}
        public string Kytkin {get; set;}
        // constructors
        // methods
        public bool Käynnistys(string valinta)
        {
            if (valinta == "1")
                return true;
            else
                return false;
        }
        public int LämpötilanSäätö(int temp)
        {
            return Lämpötila;
        }
        public int KosteudenSäätö(int kosteus)
        {
            return Kosteus;
        }
        public void Yhteenveto(int temp, int kosteus)
        {
            Lämpötila = temp;
            Kosteus = kosteus;
        }
        public bool Lopetus(string valinta)
        {
            if (valinta == "1")
                return true;
            else
                return false;
        }
        // events
        // indexer
        // destructor
    }
}
