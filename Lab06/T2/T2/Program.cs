using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab06 T2
 * 5.3.2019
 * Antti Teppo
 * Toteutettavassa sovelluksessa tulisi pysyä käsittelemään erilaisia kulkuneuvoja. Kaikilla kulkuneuvoilla on löydettävissä yhteisinä ominaisuuksina: 
 * nimi, malli, vuosimalli ja väri. Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä.
 * Polkupyörän osalta pitää pystyä erottelemaan se, että onko kyseessä vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi.
 * Veneiden osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...) ja kuinka monta istuinpaikkaa veneestä löytyy.

 * Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. 
 * Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.
 */

namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike nopsa = new Bike();
            nopsa.Name = "Nopsa";
            nopsa.Model = "nopea";
            nopsa.ModelYear = 2016;
            nopsa.Color = "Keltamusta";
            nopsa.GearWheels = false;
            nopsa.GearNames = "";
            Bike tunturi = new Bike();
            tunturi.Name = "Tunturi";
            tunturi.Model = "kaunotar";
            tunturi.ModelYear = 2018;
            tunturi.Color = "punainen";
            tunturi.GearWheels = true;
            tunturi.GearNames = "Shimano";
            Console.WriteLine(nopsa.ToString());
            Console.WriteLine(tunturi.ToString());
            Boat terhi = new Boat();
            Boat ellu = new Boat();
            terhi.Name = "Terhi";
            ellu.Name = "Ellu";
            terhi.Model = "TTR";
            ellu.Model = "kana";
            terhi.ModelYear = 1998;
            ellu.ModelYear = 2013;
            terhi.Color = "harmaa";
            ellu.Color = "musta";
            terhi.SeatCount = 4;
            ellu.SeatCount = 8;
            terhi.BoatType = "Soutuvene";
            ellu.BoatType = "Moottorivene";
            Console.WriteLine(terhi.ToString());
            Console.WriteLine(ellu.ToString());
            Console.WriteLine();
            Console.WriteLine("*********************HARJOITTELU MIELESSÄ LUODUT OLIOT LISTAAN JA SIITÄ TULOSTUS:**************************************");
            Console.WriteLine();
            List<Vehicle> ajoneuvot = new List<Vehicle>();
            ajoneuvot.Add(nopsa);
            ajoneuvot.Add(tunturi);
            ajoneuvot.Add(terhi);
            ajoneuvot.Add(ellu);
            foreach (var item in ajoneuvot)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
