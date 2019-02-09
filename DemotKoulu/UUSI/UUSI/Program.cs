using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab06 T2
 * 9.2.2019 Antti Teppo
 * Toteutettavassa sovelluksessa tulisi pysyä käsittelemään erilaisia kulkuneuvoja.
 * Kaikilla kulkuneuvoilla on löydettävissä yhteisinä ominaisuuksina: nimi, malli, vuosimalli ja väri.
 * Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä.
 * Polkupyörän osalta pitää pystyä erottelemaan se, että onko kyseessä vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi.
 * Veneiden osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...) ja kuinka monta istuinpaikkaa veneestä löytyy.
 * Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. Toteuta tämän jälkeen vaaditut luokat,
 * luo ja käytä olioita pääohjelmasta. Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan.
 * Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.
 */
namespace UUSI
{
    class Program
    {
        static void TestVehicle()
            {
            
            }
        static void Main(string[] args)
        {
            Bike bike = new Bike("Jopo", "Street", 2016, "Blue");
            bike.GearWheel = false;
            bike.GearName = "";
            Bike bike1 = new Bike("Tunturi", "StreetPower", 2010, "Black");
            bike1.GearWheel = true;
            bike1.GearName = "Shimano";
            Console.WriteLine("Name: {0}, Model: {1}, ModelYear: {2}, Color: {3}, GearWheel: {4}, GearName: {5}", bike.Name, bike.Model, bike.ModelYear, bike.Color, bike.GearWheel, bike.GearName);
            Console.WriteLine("Name: {0}, Model: {1}, ModelYear: {2}, Color: {3}, GearWheel:  {4}, GearName: {5}", bike1.Name, bike1.Model, bike1.ModelYear, bike1.Color, bike1.GearWheel, bike1.GearName);

            Console.ReadLine();
        }
    }
}
