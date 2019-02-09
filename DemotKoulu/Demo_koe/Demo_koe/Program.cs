using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Testikoe
 * https://student.labranet.jamk.fi/~salesa/csharp/exams/19k.html
 * NIMI: BLAnimal
 */
namespace JAMK.IT.TTOS0200
{
   
    class Program
    {
        static void TestaaKissat()
        {
            //Vaihe 1
            Kissa kissa1 = new Kissa();
            Kissa kissa2 = new Kissa();
            kissa1.Nimi = "Karvinen"; kissa1.Väri = "Punertava";
            kissa2.Nimi = "Tassu"; kissa2.Väri = "musta";
            //V2
            Kissa kissa3 = new Kissa("Repe");
            Kissa kissa4 = new Kissa("Touho", "harmaa");
            //V3 V4
            Kissa kissa5 = new Kissa("Jaska", "valkoinen", "uros");
            Console.WriteLine("Kissani {0} liikkuu seuraavasti {1} ja sanoo {2}", kissa5.Nimi, kissa5.Liiku(), kissa5.Ääntelee());
            //V5
            Kissa[] kissulit = new Kissa[5];
            kissulit[0] = kissa1;
            kissulit[1] = kissa2;
            kissulit[2] = kissa3;
            kissulit[3] = kissa4;
            kissulit[4] = kissa5;
            for (int i = 0; i < kissulit.Length; i++)
            {
                Console.WriteLine(kissulit[i].Nimi);
            }
            //V6
            List<Kissa> vilkkilänKissat = new List<Kissa>();
            vilkkilänKissat.Add(kissa1);
            vilkkilänKissat.Add(kissa2);
            vilkkilänKissat.Add(kissa3);
            vilkkilänKissat.Add(kissa4);
            vilkkilänKissat.Add(kissa5);
            for (int i = 0; i < 96; i++)
            {
                vilkkilänKissat.Add(new Kissa("pentu" + i, "musta"));
            }
            foreach (var kissa in vilkkilänKissat)
            {
                Console.WriteLine(kissa.Nimi + " " + kissa.Väri);
            }
            //V7
            List<Nisäkäs> eläimet = new List<Nisäkäs>();
            eläimet.Add(kissa1);
            eläimet.Add(kissa2);
            eläimet.Add(kissa3);
            Koira koira = new Koira();
            koira.Nimi = "Nalle";
            eläimet.Add(koira);
            eläimet.Add(new Koira());
            eläimet.Add(new Koira() { Nimi = "Jopi" });
            foreach (var item in eläimet)
            {
                Console.WriteLine(item.Nimi + " " + item.Ääntelee());
            }

        }
        static void Main(string[] args)
        {
            try
            {
                TestaaKissat();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
