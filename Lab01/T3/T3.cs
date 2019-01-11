using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Labra01 T3
 * Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
 */
namespace Jamk.It
{
    class Program
    {
        static void T3()
        {
            // kysytään käyttäjältä kolme lukua ja lasketaan niiden summa ja keskiarvo
            try
            {
                int a, b, c;
                int sum, average;
                Console.WriteLine("Give three numbers: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                //output
                sum = a + b + c;
                average = sum / 3;
                Console.WriteLine("Sum {0} averiage {1}", sum, average);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            
           // kutsutaan metodia T3
           T3();
 
        }
    }
}
