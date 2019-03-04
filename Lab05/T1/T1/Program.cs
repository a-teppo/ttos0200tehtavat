using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Lab05 T1
 * Antti Teppo
 * 04.03.2019
* Tee luokka ItMath, jolla on seuraava staattinen metodi:
* 
* Luvun tarkastaminen
* bool OnkoLuku(string syote): metodi tutkii annetun merkkijonon ja palauttaa true, jos syöte on muunnettavissa luvuksi (kokonaisluku tai desimaaliluku erottimena pilkku, pistettä ei hyväksytä).
* 
* Tee testausta varten luokka TestiPeti, ja sinne sopiva metodi, jolla testaat erilaisia vaihtoehtoja.
 */

namespace Jamk.It.OO
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

        static void Main(string[] args)
        {
            try
            {
                DoTest1();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
