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
            try
            {
                Console.WriteLine("kokeilua!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
