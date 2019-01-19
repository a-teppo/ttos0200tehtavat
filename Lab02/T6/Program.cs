using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra02 T6
 * Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. 
 * Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. 
 * Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle.
 */
namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rng = new Random();
                int arpa = rng.Next(1, 101);
                int arvaus;
                int maara = 0;


                do
                {
                    Console.WriteLine("Guess a number: ");
                    arvaus = int.Parse(Console.ReadLine());

                    if (arvaus < arpa)
                    {
                        Console.WriteLine("Number is bigger");
                        maara++;
                    }
                    else if (arvaus > arpa)
                    {
                        Console.WriteLine("Number is smaller");
                        maara++;
                    }
                    else
                    {
                        maara++;
                        Console.WriteLine("Great, it took " + maara + " guesses!");
                    }

                } while (arpa != arvaus);

                Console.WriteLine("Random number is " + arpa);

                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
