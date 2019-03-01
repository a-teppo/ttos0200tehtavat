using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Lab03 T6
 * Antti Teppo
 * 01.03.2019
 * Valitse jokin reaalimaailman asia ja suunnittele siitä luokkarakenne UML-editorilla. Tee uusi projekti.
 * Ohjelmoi suunnittelema luokkasi sekä käytä tekemääsi luokkaa edellisten tehtävien mukaisesti.
 */
namespace T6
{
    class Program
    {

        static void PrintData(List<Liiga> teamtable)
        {
            foreach (var item in teamtable)
            {
                Console.WriteLine("Joukkue: {0} Pelit: {1} Voitot: {2} ja Maaliero: {3}", item.TeamName, item.PlayedGames, item.Wins, item.GoalDifference);
            }
        }
        static void TestLiiga()
        {
            Liiga Tappara = new Liiga("Tappara", 12, 8, 23);
            Liiga Ilves = new Liiga("Ilves", 12, 4, -6);
            Liiga Jyp = new Liiga("Jyp", 12, 6, 4);
            Liiga Lukko = new Liiga("Lukko", 12, 1, -67);
            List<Liiga> teamtable = new List<Liiga>();
            teamtable.Add(Tappara);
            teamtable.Add(Ilves);
            teamtable.Add(Jyp);
            teamtable.Add(Lukko);
            PrintData(teamtable);
            Console.WriteLine("************************************************************");
            Lukko.AddWin();
            Console.WriteLine("Lisätty Lukolle yksi voitto: {0}", Lukko.Wins);
            Lukko.UpdateGoalDifference(5);
            Console.WriteLine("Laskettu Lukon maaliero uusiksi: {0}", Lukko.GoalDifference);
            Console.WriteLine("************************************************************");
            PrintData(teamtable);
        }

        static void Main(string[] args)
        {
            try
            {
                TestLiiga();
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
