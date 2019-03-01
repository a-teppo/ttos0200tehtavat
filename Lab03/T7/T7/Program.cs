using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Lab03 T7
 * Antti Teppo
 * 01.03.2019
 * Suunnittele UML-editorilla CD-luokka, joka sisältää ominaisuuksina tyypillisiä CD-levyyn kuuluvia tietoja. Pohdi myös mitä eri toiminnallisuuksia CD:llä voisi olla.
 * Toteuta ainakin toiminnallisuus, joka palauttaa kaikkien ominaisuuksien arvot yhtenä merkkijonona (sen avulla pääohjelmassa voisi tulostaa kaikki CD:n tiedot).
 * Tehtävässä "ei tarvitse" toteuttaa eri biisien ominaisuuksia, tätä asiaa pohditaan tulevissa demoissa, kun olio-ohjelmointiin liittyvä koostaminen otetaan esille.
 * Jos kuitenkin haluat miettiä sitä, niin se on tämän tehtävän +kohta eli voit kokeilla tehdä erillisen Biisi-luokan ja toteuttaa CD-luokan sisälle taulukon, jossa on biisejä.
 * 
 * Ohjelmoi C#:lla suunnittelemasi CD-luokka. Toteuta pääohjelmassa CD-olioita. Tiedot voit keksiä itse, niitä ei tarvitse kysyä käyttäjältä. Tulosta ruudulle CD:n tietoja.
 */

namespace T7
{
    class Program
    {
        
        static void TestCd()
        {
            CD cd1 = new CD("Tuisku", "DiibaDaaba", "HuuHaa", 14);
            CD cd2 = new CD("Tuiskun veli", "DiibaDaaba2", "HuuHaa2", 8);
            cd1.PrintData();
            cd2.PrintData();
            cd1.ToString(cd1.Artist, cd1.Name, cd1.Genre,cd1.Price);
            for (int i= 0; i < cd1.calculator; i++)
            {
                Console.Write(cd1.sentence[i]);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                TestCd();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
