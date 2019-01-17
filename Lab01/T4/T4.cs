using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra01 T4
 * Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta,
 *  tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
  */
namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age;
                Console.WriteLine("Give me your age? ");
                age = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    Console.WriteLine("You are a minor");
                }
                else if (age >= 18 && age <= 65)
                {
                    Console.WriteLine("You are an adult");
                }
                else
                {
                    Console.WriteLine("You are a senior");
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
