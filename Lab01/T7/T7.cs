using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 /* Labra01 T7
 * Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
 * Algoritmi:
 * 4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
 * Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
 * 
 */
 
namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int givenYear;
                Console.WriteLine("Give a year: ");
                givenYear = int.Parse(Console.ReadLine());

                if (givenYear % 4 == 0 && givenYear % 400 == 0)
                {
                    Console.WriteLine("Year is a leap year.");
                }
                else
                    Console.WriteLine("Year is not a leap year.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
