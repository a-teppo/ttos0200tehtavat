using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab03 T1
 *5.2.2019
 *Antti Teppo 
 *Tehtävä on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois,
 *sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu).
 */
namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool päällä = false;
                Kiuas harvia = new Kiuas();
                harvia.Merkki = "Harvia";
                Console.WriteLine("Tervetuloa saunomaan kiukaamme on merkiltään {0} ", harvia.Merkki);
                Console.WriteLine("Käynnistetäänkö kiuas? 1 = kyllä / kaikki muut merkit pitävät kiukaan pois päältä");
                string valinta;
                valinta = Console.ReadLine();
                päällä = harvia.Käynnistys(valinta);
                while (päällä)
                    {
                    Console.WriteLine("Kiuas on nyt päällä ja voit säätää kiukaan lämpötilaa sekä kosteutta");
                    Console.WriteLine("Anna haluttu lämpötila: ");
                    int lämpötila;
                    lämpötila = int.Parse(Console.ReadLine());
                    harvia.LämpötilanSäätö(lämpötila);
                    Console.WriteLine("Anna haluttu kosteusprosentti: ");
                    int kosteus;
                    kosteus = int.Parse(Console.ReadLine());
                    harvia.KosteudenSäätö(kosteus);
                    harvia.Yhteenveto(lämpötila,kosteus);
                    Console.WriteLine("Kiuas on nyt säädetty {0} asteeseen ja kosteusprosentti on {1}. Mukavia löylyhetkiä!", harvia.Lämpötila, harvia.Kosteus);
                    Console.WriteLine("Jatketaanko saunomista ja muutetaan asetuksia? 1 = kyllä / kaikki muut valinnat sammuttavat kiukaan!");
                    valinta = Console.ReadLine();
                    päällä = harvia.Lopetus(valinta);
                    }
                Console.WriteLine("Kiuas on pois päältä ja ohjelma lopetetaan!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
