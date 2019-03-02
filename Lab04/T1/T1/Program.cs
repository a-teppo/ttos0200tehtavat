using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Lab04 T1
* Antti Teppo
* 02.03.2019
* Toteuta luokka Tank, jolla on seuraavat ominaisuudet: Name (string), Type (string), CrewCount(int), Speed(float) ja SpeedMax(float) 
* sekä metodit AccerelateTo(float) ja SlowTo(float). Toteuta ominaisuudet niin että kaikilla ominaisuuksilla on luokan sisäinen taustamuuttuja, joita luokka käyttää.
* Ominaisuudet Name ja Type ovat luettavissa sekä muutettavissa ilman rajoituksia. Ominaisuus CrewCount on luettavissa ja asetettavissa. Sitä asetettaessa tarkistetaan, 
* että annettu ominaisuus on sallitulla välillä: sallittu minimi on kaksi ja maksimi kuusi. SpeedMax-ominaisuus on pelkästään luettavissa, ja sen arvo on asetettu oletuksena
* pysyvästi arvoon 100. Speed-ominaisuuden lähtöarvo on nolla ja sitä ei voi asettaa suoraan mutta sen arvon voi lukea. Speed-omainaisuuden arvoa voi muuttaa ainoastaan 
* * metodien AccerelateTo(float) ja SlowTo(float) kautta kuitenkin niin että Speed ei voi olla nollaa pienempi eikä Speedmax-arvoa suurempi. - minimi on nolla ja maksimi 100.
* Jos metodeille annettu arvo ei ole sallitulla välillä niin metodi ei muuta Speed-arvoa.
* Toteuta pääohjelma TestTank, jolla testaat eri ominaisuuksien asettamista. Kysymys: Pitääkö pääohjelman ja käyttäjän metodeja kutsuessaan jotenkin tietää,
* että metodi ei asettanutkaan nopeutta pyydettyyn arvoon?
 */
namespace T1
{
    class Program
    {
        static void PrintData(List<Tank>tanks)
        {
            foreach (var item in tanks)
            {
                Console.WriteLine("Nimi: {0}, Tyyppi: {1}, Henkilöstö: {2} kpl, Nopeus: {3} km/h, ", item.Name, item.Type, item.CrewCount, item.Speed);
            }
        }

        static void TestTank()
        {
            Tank Tiger = new Tank("Tiges", "Canon", 4);
            Tank Lyon = new Tank("Lyon", "Bazooka", 2);
            List<Tank> tanks = new List<Tank>();
            tanks.Add(Tiger);
            tanks.Add(Lyon);
            PrintData(tanks);
            Console.WriteLine("************************************************************************************");
            Tiger.CrewCount = 8;
            Lyon.CrewCount = 1;
            Tiger.AccerelateTo(100);
            Lyon.AccerelateTo(101);
            PrintData(tanks);
            Console.WriteLine("************************************************************************************");
            Tiger.SlowTo(60);
            Tiger.CrewCount=3;
            Lyon.CrewCount = 4;
            PrintData(tanks);
            Console.WriteLine("************************************************************************************");
            Tiger.AccerelateTo(125);
            PrintData(tanks);
            Console.WriteLine("************************************************************************************");
            Tiger.SlowTo(12);
            Lyon.Speed = 120;
            PrintData(tanks);
            Console.WriteLine("************************************************************************************");
            Tiger.AccerelateTo(40);
            PrintData(tanks);
            Console.WriteLine("************************************************************************************");
        }

        static void Main(string[] args)
        {
            try
            {
                TestTank();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
