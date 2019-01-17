using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Labra01 T8
 * Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
 */

namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Give a number 1: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Give a number 2: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Give a number 3: ");
                c = int.Parse(Console.ReadLine());

                if (a > b && a > c)
                {
                    Console.WriteLine("The Biggest number is " + a);
                }
                else if (b > a && b > c)
                {
                    Console.WriteLine("The Biggest number is " + b);
                }
                else if (c > a && c > b)
                {
                    Console.WriteLine("The Biggest number is " + c);
                }
                else
                    Console.WriteLine("There are same values for the biggest!");
                       
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
