using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra02 T2
 * Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
 */
namespace T2new
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] taulukko = new int [5];  // taulukon määrittely ja alustus;
                Console.WriteLine("Give first number: ");// pyydetään käyttäjältä luvut
                taulukko[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give second number: ");
                taulukko[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give first number: ");
                taulukko[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give first number: ");
                taulukko[3] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give first number: ");
                taulukko[4] = int.Parse(Console.ReadLine());
                Console.WriteLine(); // tyhjä rivi väliin selkeyttämään

                for (int i = 4; i >= 0; i--) // tulostetaan annetut luvut käänteisessä järjestyksessä
                    Console.WriteLine(taulukko[i]);

             Console.ReadLine(); // jotta saan consolin näytön jäämään näytölle

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
