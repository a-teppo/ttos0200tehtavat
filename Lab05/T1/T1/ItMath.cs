using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class ItMath
    {
        public bool Result1 { get; set; }
        public string Answer1 { get; set; }

        public ItMath(string answer1, bool result)
        {
            Answer1 = answer1;
            Result1 = result;
        }

        public static bool OnkoLuku(string answer1)
        {
            double number1;
            bool result1 = double.TryParse(answer1, out number1);
            return result1;
        }
    }
    public class TestiPeti
    {
        public static void TestMethod(string answer)
        {
            if (ItMath.OnkoLuku(answer) == true)
            {
                Console.WriteLine("Syöte {0} on luku True ", answer );
            }
            else
            {
                Console.WriteLine("Syöte {0} on luku False ", answer);
            }
        }

    }
    
}
