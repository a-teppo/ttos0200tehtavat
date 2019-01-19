using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra02 T4
 * Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). 
 */
namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              
                int a, b, c, d, e, f; // arvosanaluokat
                a = b = c = d = e = f = 0;
                int valinta = 0;

                Console.WriteLine("Give grades from 0 to 5: ");
                Console.WriteLine("Stop counting: Give a bigger number than 5!");


                do
                {
                    Console.WriteLine("Give a grade: ");
                    valinta = int.Parse(Console.ReadLine());

                    switch (valinta)
                    {
                        case 0:
                            a++;
                            break;
                        case 1:
                            b++;
                            break;
                        case 2:
                            c++;
                            break;
                        case 3:
                            d++;
                            break;
                        case 4:
                            e++;
                            break;
                        case 5:
                            f++;
                            break;
                        default:
                            break;
                    }

                } while (valinta <= 5);

                Console.WriteLine("Grades:");

                Console.Write("0: ");
                for (int i = 0; i < a; i++)
                    Console.Write("*");
                Console.WriteLine();

                Console.Write("1: ");
                for (int i = 0; i < b; i++)
                    Console.Write("*");
                Console.WriteLine();

                Console.Write("2: ");
                for (int i = 0; i < c; i++)
                    Console.Write("*");
                Console.WriteLine();

                Console.Write("3: ");
                for (int i = 0; i < d; i++)
                    Console.Write("*");
                Console.WriteLine();

                Console.Write("4: ");
                for (int i = 0; i < e; i++)
                    Console.Write("*");
                Console.WriteLine();

                Console.Write("5: ");
                for (int i = 0; i < f; i++)
                    Console.Write("*");
                Console.WriteLine();

                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
