using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Labra01 T2
 *Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):
 * 
 */
namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Give your points: ");
                int number = int.Parse(Console.ReadLine());

                if (number <= 1 || number >= 0)
                {
                    Console.WriteLine("School number is 0 ");
                }
                else if (number <= 3 || number >= 2)
                {
                    Console.WriteLine("School number is 1 ");
                }
                else if (number <= 5 || number >= 4)
                {
                    Console.WriteLine("School number is 2 ");
                }
                else if (number <= 7 || number >= 6)
                {
                    Console.WriteLine("School number is 3 ");
                }
                else if (number <= 9 || number >= 8)
                {
                    Console.WriteLine("School number is 4 ");
                }
                else if (number <= 12 || number >= 10)
                {
                    Console.WriteLine("School number is 5 ");
                }
                else
                {
                    Console.WriteLine("Number is out of bounce");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
