using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* * Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja
 * siirtämään hissi haluttuun kerrokseen (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on).
 * Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila.
 */
namespace T2
{
    public class Hissi
    {
        private int floor = 1;
        private int nykyinen = 1;
        private string name;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= 1 && value <= 5) floor = value;
                else
                    floor = nykyinen;
            }
        }
        public string Name { get; }

        public Hissi(string name)
        {
            Name = name;
        }

        public int MoveTo(int floor)
        {
            nykyinen = floor;
            return floor;
        }
    }
}

