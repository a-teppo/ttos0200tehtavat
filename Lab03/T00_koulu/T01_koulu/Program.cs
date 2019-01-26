using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*TTOS0200
 *Antti Teppo 26.1.2019
 */

namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // luodaan auto olio
                bool kiihtyikö = false;
                Car car = new Car();
                // kuinka kovaa päästään
                for (int i = 0; i < 300; i++)
                {
                    Console.WriteLine("Nopeus on: {0} ", car.Speed);
                    kiihtyikö = car.Accelerate(i);
                    if (kiihtyikö)
                        Console.WriteLine("Vauhti sen kuin kiihtyy");
                    else
                        Console.WriteLine("Älä hyydy kone!");
                    //perskules polliisi puskassa, jarrutetaan!
                    if (car.Speed > 100)
                        car.Brake(10);
                }
                // lopetus
                Console.WriteLine("Bensa loppu ja mittari näytti: {0} ", car.Speed);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
