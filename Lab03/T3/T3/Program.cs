using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab03 T3
 *6.2.2019 Antti Teppo
 *Tehtävänäsi on ohjelmoida television toiminta.Toteuta Televisio-luokan ohjelmointi sekä pääohjelma, jolla luot olion Televisio-luokasta.
 *Säädä luomaasi Televsio-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta televisio-olion käyttäminen jää näkyville.
 */
namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Televisio Tv1 = new Televisio("Samsung", "kuvaputki", 32);
                Console.WriteLine("Onnittelut uudet television hankinnasta!");
                Console.WriteLine("Merkki: {0}, Malli: {1}, Koko: {2}, ", Tv1.Merkki, Tv1.Malli, Tv1.Koko);
                Console.WriteLine("Käynnistetäänkö televsio? Kyllä = 1 ja kaikki muut valinnat Ei.");
                string valinta;
                valinta = Console.ReadLine();
                Tv1.Käynnistä(valinta);
                while (Tv1.Käynnistys)
                {
                    while (Tv1.Käynnistys)
                    {
                        Console.WriteLine("Valitse haluamasi kanava?");
                        Console.WriteLine("1 = Yle 1");
                        Console.WriteLine("2 = Yle 2");
                        Console.WriteLine("3 = MTV 3");
                        Console.WriteLine("4 = Nelonen");
                        Console.WriteLine("0 = Sammutus");
                        int kanava;
                        kanava = int.Parse(Console.ReadLine());
                        Tv1.ValitseKanava(kanava);
                        Console.WriteLine("Olion tila:");
                        Console.WriteLine("Merkki: {0}, Malli: {1}, Koko: {2}, Kanava: {3}, ÄÄni {4}", Tv1.Merkki, Tv1.Malli, Tv1.Koko, Tv1.Kanava, Tv1.Ääni);
                        while (Tv1.Säädöt && Tv1.Käynnistys)
                        {
                                    Console.WriteLine("Säädä äänenvoimakkuus haluammallesi tasolle? (0-100)");
                                    int ääni;
                                    ääni = int.Parse(Console.ReadLine());
                                    Tv1.SäädäÄäni(ääni);
                                    Console.WriteLine("Olion tila:");
                                    Console.WriteLine("Merkki: {0}, Malli: {1}, Koko: {2}, Kanava: {3}, Ääni: {4}", Tv1.Merkki, Tv1.Malli, Tv1.Koko, Tv1.Kanava, Tv1.Ääni);
                                    Console.WriteLine("Onko äänenvoimakkuus nyt sopiva? Kyllä = 1 ja kaikki muut valinnat niin voit säätää uudestaan.");
                                    valinta = Console.ReadLine();
                                    Tv1.Säädä(valinta);
                        }
                    }
                Console.WriteLine("Haluatko todella sammuttaa television? Pidä televisio käynnissä = 1 ja sammutus on mikä tahansa muu valinta");
                valinta = Console.ReadLine();
                Tv1.Käynnistä(valinta);
                }
                Console.WriteLine("Palaathan pian katsomaan televisiota. Hyvää päivän jatkoa!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
