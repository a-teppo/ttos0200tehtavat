using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra02 T3
 * Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle 
 * ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.
 */
namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const int maxIndex = 5;
                int[] array = new int[5]; // taulukon määrittely ja alustus
                int sum; // yhteenlaskun muuttuja
                Console.WriteLine("Give first points: ");// pyydetään käyttäjältä luvut
                array[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give second points: ");
                array[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give third points: ");
                array[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give fourth points: ");
                array[3] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give fifth points: ");
                array[4] = int.Parse(Console.ReadLine());
                Console.WriteLine(); // tyhjä rivi väliin selkeyttämään

                for (int i = 0; i < maxIndex; i++) // vaihtolajittelulla järjestellään taukon alkiot pienimmästä isoinpaan
                    for (int j = i + 1; j < maxIndex; j++)
                        if (array[j] < array[i])
                        {
                            int array2 = array[i];
                            array[i] = array[j];
                            array[j] = array2;
                        }
 
                sum = array[1] + array[2] + array[3]; // pudotetaan eka ja vika pois summasta

                Console.WriteLine("Total points are: " + sum);

            Console.ReadLine(); // jotta saan consolin näytön jäämään näytölle
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
