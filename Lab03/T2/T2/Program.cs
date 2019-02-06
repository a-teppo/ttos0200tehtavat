using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab03 T2
 *6.2.2019 Antti Teppo
 *Tehtävänäsi on ohjelmoida pesukoneen toiminta. 
 *Toteuta Pesukone-luokan ohjelmointi sekä pääohjelma, jolla luot olion Pesukone-luokasta.
 *Säädä pesukone-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta pesukone-olion käyttäminen jää näkyville.
 *Toteuta Pesukone-luokkaan muutamia erilaisia konstruktoreita ja alusta niitä käyttämällä oliota pääohjelmasta käsin.
 */

namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pesukone lgA = new Pesukone("LG","tnt",7,"hienopesu",true);
                Pesukone bosch = new Pesukone();
                Console.WriteLine("Konstruktoreilla alustetut tiedot:");
                Console.WriteLine("1. Pesukone olion tietoja merkki: {0}, malli: {1}, koko: {2}, pesuohjelma: {3}, kytkimen asento: {4}", lgA.Merkki, lgA.Malli, lgA.Koko, lgA.Pesuohjelma, lgA.Kytkin);
                Console.WriteLine("2. Pesukone olion tietoja merkki: {0}, malli: {1}, koko: {2}, pesuohjelma: {3}, kytkimen asento: {4}", bosch.Merkki, bosch.Malli, bosch.Koko, bosch.Pesuohjelma, bosch.Kytkin);
                Console.WriteLine("************************");
                Console.WriteLine("Valitaan pesukoneelle 1. pesuohjelma!");
                lgA.Pesuohjelmanvalinta();
                Console.WriteLine("1. Pesukone olion tietoja merkki: {0}, malli: {1}, koko: {2}, pesuohjelma: {3}, kytkimen asento: {4}", lgA.Merkki, lgA.Malli, lgA.Koko, lgA.Pesuohjelma, lgA.Kytkin);
                Console.WriteLine("************************ jatka ***********");
                Console.ReadLine();
                Console.WriteLine("Valitaan pesukoneelle 2. pesuohjelma!");
                bosch.Pesuohjelmanvalinta();
                Console.WriteLine("2. Pesukone olion tietoja merkki: {0}, malli: {1}, koko: {2}, pesuohjelma: {3}, kytkimen asento: {4}", bosch.Merkki, bosch.Malli, bosch.Koko, bosch.Pesuohjelma, bosch.Kytkin);
                Console.WriteLine("************************ jatka ***********");
                Console.ReadLine();
                Console.WriteLine("Alustetaan vielä 2. pesukoneen tietoja ja tulostetaan molempien olioiden tiedot näytölle");
                bosch.Malli = "SilverFox";
                bosch.Kytkin = true;
                Console.WriteLine("************************ jatka ***********");
                Console.ReadLine();
                Console.WriteLine("1. Pesukone olion tietoja merkki: {0}, malli: {1}, koko: {2}, pesuohjelma: {3}, kytkimen asento: {4}", lgA.Merkki, lgA.Malli, lgA.Koko, lgA.Pesuohjelma, lgA.Kytkin);
                Console.WriteLine("2. Pesukone olion tietoja merkki: {0}, malli: {1}, koko: {2}, pesuohjelma: {3}, kytkimen asento: {4}", bosch.Merkki, bosch.Malli, bosch.Koko, bosch.Pesuohjelma, bosch.Kytkin);
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
