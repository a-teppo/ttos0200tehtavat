using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Kiuas
    {
        // field variables
        // properties
        public string Merkki { get; set; }

        // constructors
        // methods
        public bool Päällä(string päällä)
        {
            Console.WriteLine("Onko kiuas päällä? K = kyllä / E = ei");
            päällä = Console.ReadLine();
            if (päällä == "K" || päällä == "k")
                return true;
            else
                return false;
                
        }
        public int lämpötila;
        public int kosteus;
        // events
        // indexer
        // destructor
    }
}
