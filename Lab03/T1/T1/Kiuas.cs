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
        private bool isOn;
        // properties
        public bool On 
        {
            get { return isOn;}
            set { }
        }
        public string Merkki {get; set;}
        public int Lämpötila {get; set;}
        public int Kosteus {get; set;}
        public string Kytkin {get; set;}
        // constructors
        // methods
        public bool Käynnistä(string valinta)
        {
            if (valinta == "1")
                return isOn = true;
            else
                return isOn = false;
        }
        public int SäädäLämpötila(int temp)
        {
            return Lämpötila;
        }
        public int SäädäKosteus(int kosteus)
        {
            return Kosteus;
        }
        public void Yhteenvedä(int temp, int kosteus)
        {
            Lämpötila = temp;
            Kosteus = kosteus;
        }
        public bool Lopeta(string valinta)
        {
            if (valinta == "1")
                return isOn = true;
            else
                return isOn = false;
        }
        // events
        // indexer
        // destructor
    }
}
