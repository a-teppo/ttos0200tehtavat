using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*koulussa opettelua
 * 
 */
namespace JAMK.IT.TTOS0200.Koostaminen1
{
    class Program
    {
        static void TestMyCar()
        {
            //hankitaan auto
            Car kaara = new Car();
            kaara.Manufacturer = "Volvo";
            kaara.Model = "V70";
            //vaihdetaan talvirenkaat
            kaara.AddTyre(BuyTyre());
            kaara.AddTyre(BuyTyre());
            kaara.AddTyre(BuyTyre());
            kaara.AddTyre(BuyTyre());
            kaara.AddTyre(BuyTyre()); // ei enää mene alle!
            //kattotaas mitä siellä alla on
            Console.WriteLine(kaara.ShowData()); 
        }
        static Tyre BuyTyre()
        {
            Tyre rinkula = new Tyre();
            rinkula.Manufacturer = "Nokian";
            rinkula.Model = "Hakkapeliitta 9";
            rinkula.Size = "205/60R16";
            return rinkula;
        }
        static void TestTyres()
        {
            Tyre rinkula = new Tyre();
            rinkula.Manufacturer = "Nokian";
            rinkula.Model = "Hakkapeliitta 9";
            rinkula.Size = "205/60R16";
            Console.WriteLine(rinkula.ToString());
        }
        static void Main(string[] args)
        {
            //TestTyres();
            TestMyCar();
            Console.ReadLine();
        }
    }
}
