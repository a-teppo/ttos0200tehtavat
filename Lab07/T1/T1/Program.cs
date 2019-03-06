using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab07 T1
 * 6.3.2019
 * Antti Teppo
 * 
 * Toteuta oheisen kuvan mukaisesti kaksi luokkaa Auto- ja Rengas. Tee kuvan mukaisesti luokille tarvittavat ominaisuudet ja metodit.
 * Tee pääohjelma, jossa luot kaksi-kolme autoa, ja varustat ne erilaisilla renkailla.
 * Autojen ja rengastietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa ne suoraan pääohjelman koodissa.
 */
namespace Jamk.It.OO
{
    class Program
    {
        static void TestMyCar()
        {
            //hankitaan auto
            Auto kaara = new Auto();
            kaara.Manufacturer = "Volvo";
            kaara.Model = "V70";
            //vaihdetaan talvirenkaat
            kaara.AddTyre(BuyTyre());
            kaara.AddTyre(BuyTyre());
            kaara.AddTyre(BuyTyre());
            kaara.AddTyre(BuyTyre());
            kaara.AddTyre(BuyTyre()); // ei enää mene alle!
            Console.WriteLine(kaara.ShowData());
        }
        static Tyre BuyTyre()
        {
            Tyre rinkula = new Tyre();
            rinkula.Manufacturer = "Nokian";
            rinkula.Model = "Hakkapeliitta 9";
            rinkula.Size = "205/60R16";
            return rinkula;
        }
        static void TestTyres()
        {
            Tyre rinkula = new Tyre();
            rinkula.Manufacturer = "Nokian";
            rinkula.Model = "Hakkapeliitta 9";
            rinkula.Size = "205/60R16";
            Console.WriteLine(rinkula.ToString());
        }
        static void Main(string[] args)
        {
            //TestTyres();
            TestMyCar();
            Console.ReadLine();
        }
    }
}
