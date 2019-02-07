using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab03T4
 *7.2.2019 Antti Teppo
 * Luo Vehicle-luokka seuraavien tietojen mukaisesti: Name:string, Speed:int,Tyres:int.
 * Toiminnot:
 * PrintData(), tulostaa Vehiclen ominaisuudet näytölle
 * ToString():string, palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona
 * Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jolla luot olion Vehicle-luokasta. Muuta olion arvoja ja tulosta olion arvoja konsolille.
 */
namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Vehicle car = new Vehicle("Kupla", 125, 16);
                car.PrintData();
                car.Name = "Rellu";
                car.Speed = 999;
                car.Tyres = 19;
                car.PrintData();
                car.ToString(car.Name,car.Speed,car.Tyres);
                for (int i = 0; i < car.laskuri; i++)
                {
                    Console.Write(car.lause[i]);
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
