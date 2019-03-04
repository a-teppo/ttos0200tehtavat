using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Lab05 T2
 * Antti Teppo
 * 04.03.2019
*Tee luokkaan ItMath staattinen metodi:

* Päivämäärän tarkastaminen
* bool OnkoPvm(string syote): metodi tutkii annetun merkkijonon ja palauttaa true, jos syöte on suomalaisessa päivämäärämuodossa siis joko muotoa "pp.kk.vv" tai "pp.kk.vvvv", eli metodi esimerkiksi tunnistaa seuraavat merkkijonot päivämääriksi "1.2.13", "1.10.2017", "12.12.2017", "24.12.17"
* Seuraavia syötteitä ei kelpuuteta: "12,12,2016" --> väärä erotin, tai "12.13.2017" --> väärä kuukausi tai "30.2.2017" --> helmikuussa ei ole kolmeakymmentä päivää!
 */
namespace Jamk.It.OO
{
    class Program
    {
        static void DoTest2()
        {
            Console.WriteLine("Give new datetime: ?");
            string newTime = Console.ReadLine();
            Console.WriteLine(ItMath.OnkoPvm(newTime));
        }

        static void Main(string[] args)
        {
            try
            {
                DoTest2();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
