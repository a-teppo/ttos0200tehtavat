using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Labra01 T5
 *Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
 */


namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int amount, hours, minutes, seconds;
                Console.WriteLine("Give me amount of seconds?");
                amount = int.Parse(Console.ReadLine());
                hours = amount / (60 * 60);
                minutes = (amount - (hours * 60 *60)) / 60;
                seconds = (amount - (hours * 60 * 60 + minutes * 60));
                Console.WriteLine("Seconds can be shown as " + hours + " hour " + minutes + " minute and " + seconds + " second");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
