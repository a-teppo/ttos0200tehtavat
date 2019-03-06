using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Kätisyys { get; set; }

        public Pelaaja(string etunimi, string sukunimi, string pelipaikka, string kätisyys)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Pelipaikka = pelipaikka;
            Kätisyys = kätisyys;
        }
        public override string ToString()
        {
            return $"{Etunimi} {Sukunimi} {Pelipaikka} {Kätisyys}";
        }
    }

    public class Seura
    {
        private List<Pelaaja> pelaajat = new List<Pelaaja>();
        public string Nimi { get; set; }
        public string Kaupunki { get; set; }
        

        public List<Pelaaja> Pelaajat { get { return pelaajat; } }

        public bool AddPelaaja(Pelaaja pelaajat)
        {
            Pelaajat.Add(pelaajat);
            return true;
        }

        public string ShowData()
        {
            string retval = $"Joukkueen: {Nimi}, ,Kotikaupunki: {Kaupunki} \n";
            foreach (var item in Pelaajat)
            {
                retval += $"- " + item.ToString() + "\n";
            }
            return retval;
        }
    }

   
 
}
