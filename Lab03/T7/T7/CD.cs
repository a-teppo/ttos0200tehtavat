using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    public class CD
    {
        public string sentence = "";
        public int calculator = 0;
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }

        public CD (string artist, string name, string genre, int price)
        {
            Artist = artist;
            Name = name;
            Genre = genre;
            Price = price;
        }

        public string ToString(string artist, string name, string genre, int price)
        {
            sentence = artist + name + genre + price;
            calculator = sentence.Length;
            return sentence;
        }

        public void PrintData()
        {
            Console.WriteLine("Artisti: {0}, CD-nimi: {1}, Genre: {2}, Hinta: {3} ", Artist, Name, Genre, Price );
        }
    }
}
