using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra01 T10
 * Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100].
 * Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
 */

namespace T10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

                for (int i = 0; i < 9; i++)
                {
                    if ((array[i]) % 2 == 0)
                    {
                        Console.WriteLine("HEP");
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
                    }
                   
                                       
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
