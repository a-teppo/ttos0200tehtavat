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
                päällä = harvia.Käynnistys();
                while (päällä)
                    {
                    Console.WriteLine("Kiuas on nyt päällä ja voit säätää kiukaan lämpötilaa sekä kosteutta");
                    harvia.LämpötilanSäätö();
                    harvia.KosteudenSäätö();
                    harvia.Yhteenveto();
                    päällä = harvia.Lopetus();
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
