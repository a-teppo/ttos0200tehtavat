using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab07 T3
 * 6.3.2019
 * Antti Teppo
 * 
 * Jääkiekon SM-liigassa on viisitoista joukkuetta ja jokaisessa joukkuuessa on noin 25 pelaajaa.
 * Tee Pelaaja-luokka, jolla on ominaisuudet: etunimi, sukunimi, pelipaikka (mv, p, h), kätisyys (L tai R).
 * Luo myös luokka Seura, jolla on ominaisuudet: nimi, kaupunki ja kokoelma Pelaaja-olioita.
 * Tee konsoli sovellus, joka osaa esittää valitun seuran pelaajat. Voit "kovakoodata" pelaajatiedot pelaajaolioihin.
 */

namespace Jamk.It.OO
{
    class Program
    {
        static void DoTest()
        {
            Pelaaja pelaaja1 = new Pelaaja("Antti", "Teppo", "p", "L");
            Pelaaja pelaaja2 = new Pelaaja("Mikko", "Paasi", "p", "R");
            Pelaaja pelaaja3 = new Pelaaja("Sami", "Virtanen", "h", "L");
            Pelaaja pelaaja4 = new Pelaaja("Pentti", "Pulkkinen", "h", "R");
            Pelaaja pelaaja5 = new Pelaaja("Janne", "Raitanen", "mv", "L");
            Seura Jyp = new Seura();
            Jyp.Nimi = "Jyp";
            Jyp.Kaupunki = "Jyväskylä";
            Jyp.AddPelaaja(pelaaja1);
            Jyp.AddPelaaja(pelaaja2);
            Jyp.AddPelaaja(pelaaja3);
            Jyp.AddPelaaja(pelaaja4);
            Jyp.AddPelaaja(pelaaja5);
            Console.WriteLine(Jyp.ShowData());
            Seura Hpk = new Seura();
            Hpk.Nimi = "Hpk";
            Hpk.Kaupunki = "Hämeenlinna";
            Hpk.AddPelaaja(pelaaja1);
            Hpk.AddPelaaja(pelaaja2);
            Hpk.AddPelaaja(pelaaja3);
            Hpk.AddPelaaja(pelaaja4);
            Hpk.AddPelaaja(pelaaja5);
            Console.WriteLine(Hpk.ShowData());
        }

        static void Main(string[] args)
        {
            try
            {
                DoTest();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
