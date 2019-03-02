using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab04 T3
 * Antti Teppo
 * 02.03.2019
 * Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100.
 * Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot olion Vahvistin-luokasta. Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla.
 * Käytä Vahvistin-luokassa get- ja set-aksessoreita. get-aksessori palauttaa äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden arvoa.
 */

namespace T3
{
    class Program
    {
        static void TestVahvistin()
        {
            Vahvistin thomson = new Vahvistin("Thomson");
            while (true)
            {
                Console.WriteLine("Give a new volume value (0-100)");
                thomson.Volume = int.Parse(Console.ReadLine());
                thomson.ChangeVolume(thomson.Volume);
                Console.WriteLine("-> Amplifier volume is set to: {0} ", thomson.Volume);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                TestVahvistin();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
