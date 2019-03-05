using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab06 T3
 * 5.3.2019
 * Antti Teppo
 * Tehtävässä tulee toteuttaa C#-ohjelma radion perustoimintojen testaamiseen.
* Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin, äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0).
* Laadi luokka kannettavan radion toteutukseksi. Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta erilaisilla voimakkuuden ja taajuuden arvoilla.
* Jätä asetus- ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa.
*/

namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio sony = new Radio("Sony", "old-T");
            Console.WriteLine(sony.ToString());
            sony.ToOn(true);
            sony.Volume = 12;
            Console.WriteLine(sony.ToString());
            sony.Volume = -1;
            Console.WriteLine(sony.ToString());
            sony.Volume = 4;
            Console.WriteLine(sony.ToString());
            sony.ChangeChannel(25500.7);
            sony.ChangeVolume(8);
            Console.WriteLine(sony.ToString());
            sony.ChangeChannel(29500.7);
            sony.ChangeVolume(-3);
            Console.WriteLine(sony.ToString());
            Console.ReadLine();
        }
    }
}
