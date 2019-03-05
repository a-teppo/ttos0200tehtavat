using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab06 T1
 * 5.3.2019
 * Antti Teppo
 * Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: 
 * työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary).
 * Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss), heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).
 * 
 */
namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kirsi = new Employee();
            kirsi.Name = "Kirsi Kernel";
            kirsi.Profession = "Teacher";
            kirsi.Salary = 1200;
            Console.WriteLine(kirsi.ToString());
            Boss mikko = new Boss();
            mikko.Name = "Mikko Mäkelä";
            mikko.Profession = "Head of me";
            mikko.Salary = 2400;
            mikko.Car = "Ford Fiesta";
            mikko.Bonus = 600;
            Console.WriteLine(mikko.ToString());
            Console.ReadLine();
        }
    }
}
