using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    class Opiskelija
    {
        /*struct Opiskelijat
        {
            public string Name;
            public int Age;
            public string Address;
            public string Hobby;
        }*/
        //public List<Opiskelija> opiskelijat;
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
        /*
        public void PrintData()
        {
                foreach (var item in opiskelijat)
                {
                    Console.WriteLine("Opiskelija nimeltä {0} on iältään {1} ja asuu osoitteessa {2} sekä harrastaa {3}", item.Name, item.Age, item.Address, item.Hobby);
                }  
        }*/
        public void Organice()
            {
            Array.Sort<>
            }
    }
}
