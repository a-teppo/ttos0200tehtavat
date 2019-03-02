using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab04 T2
 * Antti Teppo
 * 03.03.2019
 * Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja
 * siirtämään hissi haluttuun kerrokseen (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on).
 * Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila.
 */
namespace T2
{
    class Program
    {

        static void UseHissi()
        {
            Hissi kone = new Hissi("Kone");
            while (true)
            {
                Console.WriteLine("Elevator is now in floor : {0}", kone.Floor);
                Console.WriteLine("Give a new floor number (1-5)");
                kone.Floor = int.Parse(Console.ReadLine());
                kone.MoveTo(kone.Floor);
            }
         }

        static void Main(string[] args)
        {
            try
            {
                UseHissi();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
