using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100.
 * Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot olion Vahvistin-luokasta.Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla.
 * Käytä Vahvistin-luokassa get- ja set-aksessoreita.get-aksessori palauttaa äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden arvoa.
*/
namespace T3
{
    public class Vahvistin
    {
        private int volume;
        private string name;

        public string Name { get; set; }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0 && value <= 100) volume = value;
                else if (value > 100) volume = 100;
                else if (value < 0) volume = 0;
            }
        }

        public Vahvistin (string name)
        {
            Name = name;
        }

        public int ChangeVolume(int volume)
        {
            return volume;
        }
    }
}
