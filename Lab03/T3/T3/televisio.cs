using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Televisio
    {
        // field variables
        private bool isOn = false;
        private bool isOK = true;
        private int ääni;
        // properties
        public string Merkki {get; set;}
        public string Malli {get; set;}
        public int Koko {get; set;}
        public string Kanava {get; set;}
        public int Ääni {get {return ääni;}
                        set {
                            if (value >= 0 && value <= 100) {ääni = value;}
                            else ääni = -10;
                            }
                        }
        public bool Käynnistys {get { return isOn;}}
        public bool Säädöt {get { return isOK;}}
        // constructors
        public Televisio(string merkki, string malli, int koko)
           // this(merkki, malli, koko);
        {
            Merkki = merkki;
            Malli = malli;
            Koko = koko;
        }
        // methods
        public bool Käynnistä(string valinta)
        {
            if (valinta == "1")
                return isOn = true;
            else
                return isOn = false;
        }
        public string ValitseKanava(int kanava)
        {
            switch (kanava)
            {
            case 1:
                    Kanava = "Yle 1";
                    break;
            case 2:
                    Kanava = "Yle 2";
                    break;
            case 3:
                    Kanava = "MTV 3";
                    break;
            case 4:
                    Kanava = "Nelonen";
                    break;
            case 0:
                    Kanava = "tyhjä";
                    Käynnistä("0");
                    break;
             default:
                    Console.WriteLine("Tunnistamaton valinta!");
                    break;
            }
            return Kanava;
        }
        public int SäädäÄäni(int ääni)
            {
                Ääni = ääni;
                return Ääni;
            }
        public bool Säädä(string valinta)
        {
            if (valinta == "1")
                return isOK = false;
            else
                return isOK = true;
        }
        // events
        // indexer
        // destructor
    }
}
