using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab06 T5
 * 5.3.2019
 * Antti Teppo
 * 
 * Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää.
 *
 */
namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Players player1 = new Players("Timo Susi", 48, "Mottitie 5", 25000, "forward", "expired");
                Players player2 = new Players("Janne Sutinen", 34, "Kenkätie 1", 34000,"goalie", "5.6.2019");
                Players player3 = new Players("Mikko Mallikas", 29, "Pottu 2", 12000, "defender", "5.6.2022");
                Stuff stuff1 = new Stuff("Simo Salminen", 56, "Piparitie 4", 340000, "Coach");
                Stuff stuff2 = new Stuff("Sari Salminen", 54, "Piparitie 4", 290000, "Manager");
                List<Tappara> members = new List<Tappara>();
                members.Add(player1);
                members.Add(player2);
                members.Add(player3);
                members.Add(stuff1);
                members.Add(stuff2);
                foreach (var item in members)
                {
                    Console.WriteLine(item.ToString());
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
