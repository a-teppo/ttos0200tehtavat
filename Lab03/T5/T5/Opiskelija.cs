using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    class Opiskelija
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Hobby { get; set; }

        public Opiskelija (string name, int age, string address, string hobby)
        {
            Name = name;
            Age = age;
            Address = address;
            Hobby = hobby;
        }
    }
}
