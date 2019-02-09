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
        static void Main(string[] args)
        {
            try
            {
                Opiskelija first = new Opiskelija("Antti", 38, "Kotikatu 5", "jalkapalloa");
                Opiskelija second = new Opiskelija("Minna", 26, "Kotikatu 9", "ohjelmointia");
                Opiskelija third = new Opiskelija("Jani", 47, "Lintutie 7", "jääkiekkoa");
                Opiskelija fourth = new Opiskelija("Petri", 18, "Koirakuja 99", "gurlingia");
                Opiskelija fifth = new Opiskelija("Jaana", 23, "Poste restante", "salibändyä");
                List<Opiskelija> opiskelijat = new List<Opiskelija>();
                opiskelijat.Add(first);
                opiskelijat.Add(second);
                opiskelijat.Add(third);
                opiskelijat.Add(fourth);
                opiskelijat.Add(fifth);

                foreach (var item in opiskelijat)
                {
                    Console.WriteLine("Opiskelija nimeltä {0} on iältään {1} ja asuu osoitteessa {2} sekä harrastaa {3}", item.Name, item.Age, item.Address, item.Hobby);
                }
                Oppilaat oppilaat;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
                        
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public struct Oppilaat
        {
            public string Name { get; }
            public int Age { get; }
            public string Address { get; }
            public string Hobby { get; }
        }
        public Oppilaat(string name, int age, string address, string hobby)
        {
            Name = name;
            Age = age;
            Address = address;
            Hobby = hobby;
        }
    }

}
