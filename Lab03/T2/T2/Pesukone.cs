using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Pesukone
    {
        // field variables
        // properties
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int Koko { get; set; }
        public string Pesuohjelma { get; set; }
        public bool Kytkin { get; set; }
        // constructors
        public Pesukone ()
        {
            Merkki = "Bosch";
            Koko = 8;
        }
        public Pesukone(string merkki, string malli, int koko, string pesuohjelma, bool kytkin)
        {
            Merkki = merkki;
            Malli = malli;
            Koko = koko;
            Pesuohjelma = pesuohjelma;
            Kytkin = kytkin;
        }
        // methods
        public string Pesuohjelmanvalinta()
        {
            int Valinta=0;
            Console.WriteLine("Valitse haluttu pesuohjelma: 1 = valkopyykki, 2 = kirjopesu tai 3 = hienopesu");
            Valinta = int.Parse(Console.ReadLine());
            switch (Valinta)
            {
                case 1:
                    Console.WriteLine("Valittu pesuohjelmaksi: valkopyykki");
                    Pesuohjelma = "valkopyykki";
                    break;
                case 2:
                    Console.WriteLine("Valittu pesuohjelmaksi: kirjopesu");
                    Pesuohjelma = "kirjopesu";
                    break;
                case 3:
                    Console.WriteLine("Valittu pesuohjelmaksi: hienopesu");
                    Pesuohjelma = "hienopesu";
                    break;
            }
            return Pesuohjelma;
        }
        // events
        // indexer
        // destructor
    }
}
