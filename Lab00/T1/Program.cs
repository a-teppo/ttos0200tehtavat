using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " ";
            Console.WriteLine("Please, give your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello World and Hello {0}!", name);
        }
    }
}
