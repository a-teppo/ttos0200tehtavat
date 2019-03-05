using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public virtual double Salary { get; set; }

        public override string ToString()
        {
            return $"Työntekijä: {this.Name}, Ammatti: {this.Profession}, Palkka: {this.Salary} euroa.";
        }
    }
    public class Boss:Employee
    {
        private double salary;

        public string Car { get; set; }
        public double Bonus { get; set; }
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

        public override string ToString()
        {
            return base.ToString() + $" josta bonuksen osuus on {Bonus} ja autona on {Car}.";
        }

    }
}
