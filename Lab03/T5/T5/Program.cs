using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab03 T5
 * 7.2.2019 Antti Teppo
 * Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja.
 * Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma,
 * joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa).
 * Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta.
 */

namespace Jamk.It.OO
{
    class Program
    {
        static void TestaaOpiskelijat()
        {
            Opiskelija first = new Opiskelija("Antti", 38, "Kotikatu 5", "jalkapalloa");
            Opiskelija second = new Opiskelija("Minna", 26, "Kotikatu 9", "ohjelmointia");
            Opiskelija third = new Opiskelija("Jani", 47, "Lintutie 7", "jääkiekkoa");
            Opiskelija fourth = new Opiskelija("Petri", 18, "Koirakuja 99", "gurlingia");
            Opiskelija fifth = new Opiskelija("Jaana", 23, "Poste restante", "salibändyä");
            Opiskelija[] opiskelijat = new Opiskelija[5];
            opiskelijat[0] = first;
            opiskelijat[1] = second;
            opiskelijat[2] = third;
            opiskelijat[3] = fourth;
            opiskelijat[4] = fifth;
            PrintData(opiskelijat);
            Console.WriteLine("*************************************************************");
            Console.WriteLine("Shorted By Age:");
            SortByAge(opiskelijat);
            PrintData(opiskelijat);
            Console.WriteLine("*************************************************************");
            Console.WriteLine("Shorted By Name:");
            SortByName(opiskelijat);
            PrintData(opiskelijat);
        }

        static void SortByAge(Opiskelija[] opiskelijat)
        {
            for (int i = 0; i < opiskelijat.Length; i++)
                for (int j = i+1; j < opiskelijat.Length; j++)
                    if (opiskelijat[j].Age < opiskelijat[i].Age)
                    {
                        Opiskelija Apu = opiskelijat[i];
                        opiskelijat[i] = opiskelijat[j];
                        opiskelijat[j] = Apu;
                    }
        }
        static void SortByName(Opiskelija[] opiskelijat)
        {
            for (int i = 0; i < opiskelijat.Length; i++)
                for (int j = i + 1; j < opiskelijat.Length; j++)
                    if (string.Compare(opiskelijat[j].Name, opiskelijat[i].Name) < 0)
                    {
                        Opiskelija Apu = opiskelijat[i];
                        opiskelijat[i] = opiskelijat[j];
                        opiskelijat[j] = Apu;
                    }
        }
        static void PrintData(Opiskelija[] opiskelijat)
        {
            for (int i = 0; i < opiskelijat.Length; i++)
            {
                Console.WriteLine(opiskelijat[i].Name + ",  " + opiskelijat[i].Age + ",  " + opiskelijat[i].Address + ",  " + opiskelijat[i].Hobby);
            }

        }

        static void Main(string[] args)
        {
            try
            {
                TestaaOpiskelijat();
                Console.ReadLine();
            }
                        
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }

}
