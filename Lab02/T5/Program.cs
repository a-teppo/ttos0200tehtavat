using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra02 T5
 * Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.
 */
namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x; // puun korkeus

                    Console.WriteLine("Give a number? ");
                    x = int.Parse(Console.ReadLine());

                        if (x <= 2)
                        {
                            Console.WriteLine("Give a bigger number!");
                            x = int.Parse(Console.ReadLine());
                        }
                x = x - 2; //puun korkeudesta pois rungon osuus (2 riviä)
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < (x-i-1) ; j++)
                        Console.Write(" ");
                    {
                        for (int y = 0; y < (i * 2 + 1); y++)
                            Console.Write("*");
                            Console.WriteLine();
                    }
                }
                for(int i = 0; i < 2; i++)
                { 
                    for (int k = 0; k < (x-1) ; k++)
                        Console.Write(" ");
                    { 
                    for (int y = 0; y < 1; y++)
                        Console.Write("*");
                        Console.WriteLine();
                    }
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
