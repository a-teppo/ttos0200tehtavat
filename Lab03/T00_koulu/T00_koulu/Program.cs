using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Antti Teppo
 *26.1.2019
 *Demoa koulussa
 * 
 * 
 */
namespace Jamk.It.OO
{
    class DogDemo
    {
        static void Main(string[] args)
        {
            try
            {
                // luodaan koira olioita
                Dog koira = new Dog();
                Dog koira2 = new Dog();
                // asetetaan ominaisuuksia
                koira.Name = "Sessa";
                koira2.Name = "Jaska";
                // luodaan koiratarha (kokoelma koiria)
                // näytetään koirien ominaisuudet
                Console.WriteLine("Minulla on kaksi koiraa nimeltään {0} ja {1}", koira.Name, koira2.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
