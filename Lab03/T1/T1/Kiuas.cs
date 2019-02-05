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
        public bool Käynnistys()
        {
            Console.WriteLine("Käynnistetäänkö kiuas? 1 = kyllä / kaikki muut merkit pitävät kiukaan pois päältä");
            Kytkin = Console.ReadLine();
            if (Kytkin == "1")
                return true;
            else
                return false;
        }
        public int LämpötilanSäätö()
        {
            Console.WriteLine("Anna haluttu lämpötila: ");
            Lämpötila = int.Parse(Console.ReadLine());
            return Lämpötila;
        }
        public int KosteudenSäätö()
        {
            Console.WriteLine("Anna haluttu kosteusprosentti: ");
            Kosteus = int.Parse(Console.ReadLine());
            return Kosteus;
        }
        public void Yhteenveto()
        {
            Console.WriteLine("Kiuas on nyt säädetty {0} asteeseen ja kosteusprosentti on {1}. Mukavia löylyhetkiä!", Lämpötila, Kosteus);
        }
        public bool Lopetus()
        {
            Console.WriteLine("Jatketaanko saunomista ja muutetaan asetuksia? 1 = kyllä / kaikki muut valinnat sammuttavat kiukaan!");
            Kytkin = Console.ReadLine();
            if (Kytkin == "1")
                return true;
            else
                return false;
        }
        // events
        // indexer
        // destructor
    }
}
