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
* bool OnkoPvm(string syote): metodi tutkii annetun merkkijonon ja palauttaa true, jos syöte on suomalaisessa päivämäärämuodossa siis joko muotoa "pp.kk.vv" tai "pp.kk.vvvv",
* eli metodi esimerkiksi tunnistaa seuraavat merkkijonot päivämääriksi "1.2.13", "1.10.2017", "12.12.2017", "24.12.17"
* Seuraavia syötteitä ei kelpuuteta: "12,12,2016" --> väärä erotin, tai "12.13.2017" --> väärä kuukausi tai "30.2.2017" --> helmikuussa ei ole kolmeakymmentä päivää!
 */

namespace T1
{
    class Program
    {
        static void DoTest1()
        {
            ItMath first = new ItMath("11", false);
            ItMath second = new ItMath("11.11", false);
            ItMath third = new ItMath("11,11", false);
            ItMath fourth = new ItMath("kukkuu", false);
            ItMath fifth = new ItMath("-11.12", false);
            ItMath sixth = new ItMath("-11,12", false);
            List<ItMath> strings = new List<ItMath>();
            strings.Add(first);
            strings.Add(second);
            strings.Add(third);
            strings.Add(fourth);
            strings.Add(fifth);
            strings.Add(sixth);
            Console.WriteLine("Syöte {0} on luku: {1} ", first.Answer1, ItMath.OnkoLuku(first.Answer1));
            Console.WriteLine("Syöte {0} on luku: {1} ", second.Answer1, ItMath.OnkoLuku(second.Answer1));
            Console.WriteLine("Syöte {0} on luku: {1} ", third.Answer1, ItMath.OnkoLuku(third.Answer1));
            Console.WriteLine("Syöte {0} on luku: {1} ", fourth.Answer1, ItMath.OnkoLuku(fourth.Answer1));
            Console.WriteLine("Syöte {0} on luku: {1} ", fifth.Answer1, ItMath.OnkoLuku(fifth.Answer1));
            Console.WriteLine("Syöte {0} on luku: {1} ", sixth.Answer1, ItMath.OnkoLuku(sixth.Answer1));
            TestiPeti.TestMethod("12.12");
            TestiPeti.TestMethod("-32");
            while (true)
            {
                Console.WriteLine("Give a new numeric string to computer?");
                string answer2 = Console.ReadLine();
                TestiPeti.TestMethod(answer2);
                Console.WriteLine("Do you want to continue? N/n = no, press anything else to continue!");
                string answer3 = Console.ReadLine();
                if (answer3 == "N" || answer3 == "n")
                    break;
            }

        }

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
