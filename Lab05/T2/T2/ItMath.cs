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

        public static bool OnkoPvm(string newTime)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(newTime, "dd.MM.yy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine(parsedDate.ToString("dd.MM.yy"));
                return true;
            }
            else if (DateTime.TryParseExact(newTime, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine(parsedDate.ToString("dd.MM.yyyy"));
                return true;
            }
            else if (DateTime.TryParseExact(newTime, "d.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine(parsedDate.ToString("d.MM.yyyy"));
                return true;
            }
            else if (DateTime.TryParseExact(newTime, "dd.M.yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine(parsedDate.ToString("dd.M.yyyy"));
                return true;
            }
            else if (DateTime.TryParseExact(newTime, "d.M.yy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine(parsedDate.ToString("d.M.yy"));
                return true;
            }
            else if (DateTime.TryParseExact(newTime, "d.M.yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine(parsedDate.ToString("d.M.yyyy"));
                return true;
            }
            else
                Console.WriteLine("Unable to convert to a date and time.");
            return false;
        }
    }

    public class TestiPeti
    {
        public static void TestMethod(string answer)
        {
            if (ItMath.OnkoLuku(answer) == true)
            {
                Console.WriteLine("Syöte {0} on luku True ", answer);
            }
            else
            {
                Console.WriteLine("Syöte {0} on luku False ", answer);
            }
        }

    }
}
