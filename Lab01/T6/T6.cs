using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra01 T6
 *Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
 * Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
 */

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const double consumption = 7.02;
                const double gasPrize = 1.595;
                double distance, gasConsumption;
                double cost = 0.00;

                Console.WriteLine("Tell me, how far you are going to drive? ");
                distance = double.Parse(Console.ReadLine());
                gasConsumption = (distance/100)*consumption;
                cost = (gasConsumption * gasPrize);
                cost = Math.Round(cost, 2);

                Console.WriteLine("Gasoline consume is " + gasConsumption + " liters and cost is " + cost + " euros");


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
