using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 
 */
namespace JAMK.IT.TTO0200
{
    class Program
    {
        static void Main(string[] args)
        {
            //eka työntekijä
            Employee e = new Employee();
            e.Name = "Kirsi Kernel";
            e.Profession = "teacher";
            e.Salary = 1200;
            //NÄYTETÄÄN kIRSIN TIEDOT
            Console.WriteLine(e.ToString());
            //iso pomo
            Boss boss = new Boss();
            boss.Name = "Matti Mainio";
            boss.Profession = "head of school";
            boss.Salary = 2200;
            boss.Bonus = 500;
            boss.Car = "VW Golf";
            Console.WriteLine(boss.ToString());
            
        }
    }
}
