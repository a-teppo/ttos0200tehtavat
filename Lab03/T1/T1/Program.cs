using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab03 T1
 *Antti Teppo 26.1.2019
 *Tehtävänäsi on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois,
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
                
                Kiuas kiuas = new Kiuas();
                Kiuas kiuas2 = new Kiuas();
                //asetetaan ominaisuuksia
                kiuas.Merkki = "Harvia";
                kiuas2.Merkki = "HomeMade";

                Console.WriteLine("Onko kiuas päällä? K = kyllä / E = ei");
                kiuas.Päällä = Console.ReadLine();
                Console.WriteLine("Kiuas on {0}", kiuas.Päällä);
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
