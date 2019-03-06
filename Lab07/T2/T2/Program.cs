using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Lab07 T2
 * 6.3.2019
 * Antti Teppo
 * 
 * Tee Rengas-luokka (tai käytä edellisen tehtävän luokkaa), jolla on seuraavat ominaisuudet: Valmistaja, Malli ja Rengaskoko.
 * Tee tämän jälkeen Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) ja käytä tekemääsi Rengas-luokkaa apuna renkaiden käsittelyyn.
 * Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina List-rakenteeseen.
 * Tee pääohjelma, jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä) renkaineen. Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa.
 * 
 */

namespace Jamk.It.OO
{
    class Program
    {
        static void TestMyCar()
        {
            Kulkuneuvot kaara = new Kulkuneuvot();
            kaara.Manufacturer = "Volvo";
            kaara.Model = "V70";
            kaara.AddTyre4(BuyTyre1());
            kaara.AddTyre4(BuyTyre1());
            kaara.AddTyre4(BuyTyre1());
            kaara.AddTyre4(BuyTyre1());
            kaara.AddTyre4(BuyTyre1()); 
            Console.WriteLine(kaara.ShowData());
            Kulkuneuvot mopo = new Kulkuneuvot();
            mopo.Manufacturer = "Yamaha";
            mopo.Model = "P100";
            mopo.AddTyre2(BuyTyre2());
            mopo.AddTyre2(BuyTyre2());
            mopo.AddTyre2(BuyTyre2());
            Console.WriteLine(mopo.ShowData());
        }
        static Rengas BuyTyre1()
        {
            Rengas rinkula = new Rengas();
            rinkula.Manufacturer = "Nokian";
            rinkula.Model = "Hakkapeliitta 9";
            rinkula.Size = "205/60R16";
            return rinkula;
        }
        static Rengas BuyTyre2()
        {
            Rengas rinkula2 = new Rengas();
            rinkula2.Manufacturer = "Pirelli";
            rinkula2.Model = "WellDone";
            rinkula2.Size = "125/35R12";
            return rinkula2;
        }
        static void Main(string[] args)
        {
            try
            {
                TestMyCar();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
