using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra01 T9
 * Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
 */

namespace T9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number, sum=0;

                do
                {
                    Console.WriteLine("Give a number: ");
                    number = int.Parse(Console.ReadLine());
                    sum += number;

                } while (number != 0);

                Console.WriteLine("Sum is " + sum);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
