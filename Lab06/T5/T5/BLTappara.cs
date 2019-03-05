using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Tappara
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        public Tappara(string name, int age, string address, double salary)
        {
            Name = name;
            Age = age;
            Address = address;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Address: {Address}, Salary: {Salary}";
        }
    }

    class Players : Tappara
    {
        public string Position { get; set; }
        public string ContractExpiry { get; set; }

        public Players(string name, int age, string address, double salary, string position, string contractexpiry)
            :base(name,age,address,salary) 
        {
            Position = position;
            ContractExpiry = contractexpiry;
        }

        public override string ToString()
        {
            return base.ToString() + $" Position: {Position}, ContractExpiry {ContractExpiry} ";
        }
    }

    class Stuff : Tappara
    {
        public string Role { get; set; }

        public Stuff(string name, int age, string address, double salary, string role)
            : base(name, age, address, salary)
        {
            Role = role;
        }

        public override string ToString()
        {
            return base.ToString() + $" Role: {Role}";
        }
    }
}
