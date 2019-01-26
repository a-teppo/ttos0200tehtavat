using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Antti Teppo
 *26.1.2019
 *Demoa koulussa
 * 
 * 
 */
namespace Jamk.It.OO
{
    class DogDemo
    {
        static void ShowDogsData(List<Dog> koirat)
        {
            foreach (var item in koirat)
            {
                Console.WriteLine("Koira nimeltä {0} on väriltään {1} ja sukupuoleltaan {2} sekä rodultaan {3}", item.Name, item.Color, item.DogGender, item.Breed);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                // luodaan koira olioita
                Dog koira = new Dog(Gender.Male);
                Dog koira2 = new Dog(Gender.Male);
                Dog tyttokoira = new Dog(Gender.Female);
                Dog poikakoira = new Dog(Gender.Male);
                // asetetaan ominaisuuksia
                koira.Name = "Sessa";
                koira.Color = "Musta";
                koira2.Name = "Jaska";
                //koira2.Color = "Ruskea pilkullinen";
                tyttokoira.Name = "Sussie";
                tyttokoira.Color = "Valkoinen";
                poikakoira.Name = "Sepe";
                // luodaan koiratarha (kokoelma koiria)
                List<Dog> koirat = new List<Dog>();
                //lisätään meidän koirat listaaan
                koirat.Add(koira);
                koirat.Add(koira2);
                koirat.Add(tyttokoira);
                koirat.Add(poikakoira);
                koirat.Add(new Dog("Pikke", "vaalea", Gender.Male));
                koirat.Add(new Dog("Camilla", "Harmaa", Gender.Female, "susikoira"));
                // näytetään koirien ominaisuudet
                ShowDogsData(koirat);
                // Console.WriteLine("Minulla on kaksi koiraa nimeltään {0} ja {1}", koira.Name, koira2.Name);
                // Console.WriteLine("Koiran {0} väri {1} ja sukupuoli {2}", koira.Name, koira.Color, koira.DogGender);
                // laitetaan Jaska murisemaan ja haukkumaan
                // Console.WriteLine(koira2.Growl());
                // Console.WriteLine(koira2.Bark(10));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
