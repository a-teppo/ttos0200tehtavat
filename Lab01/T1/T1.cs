using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Labra01 T1
 * Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme).
 * Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
 */
namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number;
                Console.Write("Give a number... (1-3) : ");
                number = int.Parse(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Number is one");
                }
                else if (number == 2)
                {
                    Console.WriteLine("Number is two");
                }
                else if (number == 3)
                {
                    Console.WriteLine("Number is three");
                }
                else
                {
                    Console.WriteLine("Number is something else");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
