using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra02 T8
 * Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause). Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.
 */
namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string lause; // luodaan muuttuja lause
                Console.WriteLine("Give me a sentence:");
                lause = Console.ReadLine();
                //Console.WriteLine("You wrote: " + lause);
                int laskuri = 0;
                laskuri = lause.Length; // lasketaan lauseen pituus
              
                char[] array = new char[laskuri]; // käännetään lauseen järjestys ja tallennetaan se char taulukkoon
                int a = 0;
                for (int i = laskuri-1; i >= 0; i--)
                    {
                        array[a++] = lause[i];
                    }

                //Console.WriteLine(array);
                //Console.WriteLine(lause);

                string lause1 = new string(array); // muutetaan tallennettu char taulukko string muotoon

                if (string.Compare(lause, lause1) == 0) // vertaillaan lause ja lause1 keskenään
                    {
                        Console.WriteLine("Your sentence is a palidrom!");
                    }
                    else
                    {
                        Console.WriteLine("Your sentence is not a palidrom!");
                    }
                    
                

                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
