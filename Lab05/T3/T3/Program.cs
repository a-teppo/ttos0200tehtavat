using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab05 T3
 * Antti Teppo
 * 4.3.2019
 * Tee ohjelma joka kysyy käyttäjältä yhdestä kymmeneen lukua, niin että käyttäjä antaa luvut yhtenä merkkijonona pilkulla erotettuna. Siis esimerkiksi käyttäjä antaa merkkijonon "50,60,70,80,90". Tee luokka ItParser ja sille kolme staattista metodia. Metodeille annetaan argumenttina käyttäjän antama merkkijono ja metodit palauttavat tuloksen. Toteuta metodit:
*  int Count(string syote) ; metodi palauttaa montako lukua annetussa merkkijonossa on
* int Sum(string syote) ; metodi palauttaa merkkijonon lukujen summan
* int Average(string syote) ; metodi palauttaa merkkijonon lukujen keskiarvon
* Tee pääohjelma TestParser(), jolla testaat tekemiäsi metodeja erilaisilla lähtöarvoilla. Tarkista että metodisi varmasti palauttavat oikein eri tilanteissa.
* Oheisessa kuvassa on suoritettu kaksi testiä, sekä kahdella että viidellä luvulla.
 */ 
 
namespace Jamk.It.OO
{
    class Program
    {
        static void TestParser()
        {
            Console.WriteLine("Anna syöte jossa on lukuja 1-10 kpl ja erottelet luvut pilkulla!");
            string test = Console.ReadLine();
            Console.WriteLine("Syötteessä oli {0} lukua. ", ItParser.Count(test));
            Console.WriteLine("Syötteiden lukujen summa on: {0} ", ItParser.Sum(test));
            Console.WriteLine("Syötteiden keskiarvo on {0} ", ItParser.Average(test));
        }

        static void Main(string[] args)
        {
            try
            {
                TestParser();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
