using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*JOs haluaa korvata (ylikirjoittaa) metodin tai ominaisuuden, on käytettävä joko virtual tai abstract
 * 
 */
namespace JAMK.IT.TTO0200
{
    public class Employee
    {
        //properties
        public string Name { get; set; }
        public string Profession { get; set; }
        public virtual double Salary { get; set; }
        //methods
        public override string ToString()
        {
            return $"Työntekijä {this.Name} ammatti {this.Profession} palkka {this.Salary} euroa "; // voi olla myös ilman this alkua!
        }

    }
    public class Boss : Employee
    {
        public string Car {get;set;}
        public double Bonus { get; set; }
        // ylikirjoitetaan salary ominaisuus
        private double salary;
        public override double Salary
        {
            get
            {
                return salary + Bonus;
            }
            set
            {
                salary = value;
            }
        }
        // ylikirjoitetaan kantaluokan ToString() metodi
        public override string ToString()
        {
            return base.ToString() + $"josta bonus on {Bonus} ja työsuhdeauto on {Car}";
        }
    }
}
