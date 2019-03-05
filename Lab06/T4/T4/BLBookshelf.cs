using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Bookshelf
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Purchased { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Value: {Value} euros, Purchased: {Purchased} ";
        }
    }

    public class Literature : Bookshelf
    {
        public string Writer { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Writer: {Writer}, Pages: {Pages}";
        }
    }

    public class Music : Bookshelf
    {
            public string Artist { get; set; }
            public int Songs { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Artist: {Artist}, Songs: {Songs} pcs";
        }
    }

    public class SmartDevices : Bookshelf
    {
        public string Manufacturer { get; set; }
        public double Size { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Manufacturer: {Manufacturer}, Size: {Size} inches";
        }
    }

        

    
}
