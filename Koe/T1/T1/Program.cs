using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
   
    class Program
    {
        static void ListaaTiedot(List<Henkilöauto> henkilöautot)
        {
            foreach (var item in henkilöautot)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", item.Merkki, item.Malli, item.Rekisterinumero, item.Nopeus);
            }
        }

        static void ListaaTiedot(List<Route66> kaikkia)
        {
            foreach (var item in kaikkia)
            {
                Console.WriteLine("{0}, {1}, {2} ", item.Merkki, item.Rekisterinumero, item.Nopeus);
            }
        }
        static void TestaaRoute66()
        {
            Henkilöauto auto1 = new Henkilöauto(55);
            Henkilöauto auto2 = new Henkilöauto(80, "AAA-111");
            Henkilöauto auto3 = new Henkilöauto(120, "BBB-222", "Volvo", "Sisukas");
            Console.WriteLine("Auto 1: Nopeus on {0}", auto1.Nopeus);
            Console.WriteLine("Auto 2: Nopeus on {0} ja Rekkari: {1}", auto2.Nopeus, auto2.Rekisterinumero);
            Console.WriteLine("Auto 3: Nopeus on {0} ja Rekkari: {1}, Merkki: {2}, Malli: {3}", auto3.Nopeus, auto3.Rekisterinumero, auto3.Merkki, auto3.Malli);
            Kuormaauto[] kuormaautot = new Kuormaauto[5];
            Kuormaauto kuorma1 = new Kuormaauto(80);
            Kuormaauto kuorma2 = new Kuormaauto(90);
            Kuormaauto kuorma3 = new Kuormaauto(100);
            Kuormaauto kuorma4 = new Kuormaauto(110);
            Kuormaauto kuorma5 = new Kuormaauto(86);
            kuormaautot[0] = kuorma1;
            kuormaautot[1] = kuorma2;
            kuormaautot[2] = kuorma3;
            kuormaautot[3] = kuorma4;
            kuormaautot[4] = kuorma5;
            for (int i = 0; i < kuormaautot.Length; i++)
            {
                Console.WriteLine("Kuorma-auto: " + (i + 1) + ". Nopeus:" + kuormaautot[i].Nopeus);
            }
            List<Henkilöauto> henkilöautot = new List<Henkilöauto>();
            Henkilöauto auto6 = new Henkilöauto(80, "AAB-112", "Volvo", "Liisa1");
            Henkilöauto auto7 = new Henkilöauto(85, "AAB-113", "Nissan", "Sunny");
            Henkilöauto auto8 = new Henkilöauto(95, "AAB-114", "Mersu", "560");
            Henkilöauto auto9 = new Henkilöauto(120, "AAB-115", "Lada", "100");
            Henkilöauto auto10 = new Henkilöauto(100, "AAB-117", "Mazda", "CX");
            henkilöautot.Add(auto6);
            henkilöautot.Add(auto7);
            henkilöautot.Add(auto8);
            henkilöautot.Add(auto9);
            henkilöautot.Add(auto10);
            for (int i = 0; i <= (99 - 5); i++)
            {
                henkilöautot.Add(new Henkilöauto("AAB-1" + i, "merkki" + i));
            }

            foreach (var kissa in henkilöautot)
            {
                Console.WriteLine(kissa.Rekisterinumero + " " + kissa.Merkki);
            }
            ListaaTiedot(henkilöautot);
            List<Route66> kaikkia = new List<Route66>();
            kaikkia.Add(kuorma1);
            kaikkia.Add(kuorma2);
            kaikkia.Add(kuorma3);
            kaikkia.Add(auto6);
            kaikkia.Add(auto7);
            kaikkia.Add(auto8);
            kaikkia.Add(auto9);
            ListaaTiedot(kaikkia);

        }
        static void Main(string[] args)
        {
            // 6-7/7
            // Pääsin kohtaa 7 ja tämä kertoo omasta osaamisesta eli hidasta on ja pienikin muutos teettää paljon töitä.
            // Osasin tehdä listan kaikista olioista mutta nyt jäin kiinni siihen miten saan kaikki tiedot ulos, koska kantaluokka on erilainen
            // ajan kanssa saisin pihalle mutta en tässä ajassa nyt enempää. Nyt toimii tämäkin kohta osittain.
            //
            try
            {
                TestaaRoute66();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
