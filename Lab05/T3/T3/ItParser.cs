using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class ItParser
    {
        
    public static int Count(string test)
        {
            var numbers = test.Split(',').Select(Int32.Parse).ToList();
            int count = numbers.Count;
            return count;
        }

    public static int Sum(string test)
        {
            var numbers = test.Split(',').Select(Int32.Parse).ToList();
            int sum = numbers.Sum();
            return sum;
        }

    public static int Average(string test)
        {
            var numbers = test.Split(',').Select(Int32.Parse).ToList();
            int average = numbers.Sum()/numbers.Count;
            return average;
        }

    }
    
}
