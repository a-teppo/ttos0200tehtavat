using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
