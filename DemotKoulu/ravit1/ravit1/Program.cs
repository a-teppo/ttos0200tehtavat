using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    struct Ohjastajat
    {
        public string Nimi;
        public int Startit;
        public int Voitot;
        public double VoittoProsentti;
        public float VoittoSumma;
    }

    public class OhjastajatTiedot
    {
        static void LueTiedostoVerSimppeli()
        {
            try
            {
                //luetaan tiedosto rivi kerrallaan ja näyttää rivin sellaisenn
                string filename = @"Z:\ohjelmoinnin_perusteet\ohjastajat2018.txt";
                int cnt = 0;
                string line = "";
                System.IO.StreamReader reader = new System.IO.StreamReader(filename);
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(cnt + ":" + line);
                    cnt++;
                }
                reader.Close();
                Console.WriteLine("Everything done properly, have a nice day!");
            }
            catch
            {
                throw;
            }
        }
        static void LueOhjastajatVerStruct()
        {
            try
            {

                // luetaan ohjastaja tiedot kerralla sisään ja muutetaan kukin rivi struktiksi
                string sep = ";";
                string filename = @"Z:\ohjelmoinnin_perusteet\ohjastajat2018.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                // käydään array läpi ja muutetaan rivi Ohjastajaksi
                Ohjastajat kuski;
                int cnt = lines.Length;
                Console.WriteLine($"Ohjastajia tiedostossa {cnt}");
                //TODO
                for (int i = 1; i < cnt; i++)
                {
                    // erotellaan riviltä sanat, erottimena on
                    string[] words = lines[i].Split(sep.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 2)
                    {
                        kuski.Nimi = words[0];
                        kuski.Startit = int.Parse(words[1]);
                        kuski.Voitot = int.Parse(words[2]);
                        kuski.VoittoSumma = float.Parse(words[7]);
                        // lasketaan voittoprosentti
                        kuski.VoittoProsentti = (100F * kuski.Voitot / kuski.Startit);
                        // tulos näkyviin
                        Console.WriteLine($"Kuski {kuski.Nimi} ajoi {kuski.Startit} lähtöä ja voittoprosentti oli {kuski.VoittoProsentti}");
                    }

                }
                // lopetus
                Console.WriteLine("That's all folks!");
                Console.ReadLine();

            }
            catch
            {
                throw;
            }
        }

    }

        static void Main(string[] args)
        {
            try
            {
                LueOhjastajatVerStruct();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ohjelman suorituksessa tapahtui virhe " + ex.Message);
            }
        }
}


