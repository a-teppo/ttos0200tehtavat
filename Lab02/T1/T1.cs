using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Labra02 T1
 * Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
 * Käyttäjä antaa syötteenä tähtirivien lukumäärän
 */
namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
	        {
                int x; // rivien määrä
                Console.WriteLine("Give number of rows? ");
                x = int.Parse(Console.ReadLine());

                for (int i = 0; i < x; i++)
                    {
                    for ( int y = 0; y<(i+1); y++)
                        Console.Write("*");
                    Console.WriteLine();
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
