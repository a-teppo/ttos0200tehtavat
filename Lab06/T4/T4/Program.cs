using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Lab06 T4
 * 5.3.2019
 * Antti Teppo
 * ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita: kirjoja, lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, puhelimia, tabletteja, läppäreitä, ... jne. 
 * Pohdi UML-kaaviota käyttäen millaisia luokkarakenteita (ainakin luokkien ja ominaisuuksien osalta) esiintyy ja käytä apua perintää, jos tavaroille löytyy yhteisiä ominaisuuksia.
 * Toteuta tämän jälkeen muutamia luokkia, joissa perintää esiintyy. Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot olioita.
 */

namespace Jamk.It.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Literature sports = new Literature();
                Music rock = new Music();
                SmartDevices phone = new SmartDevices();
                sports.Name = "David Beckman";
                sports.Value = 4;
                sports.Purchased = "21.12.2012";
                sports.Writer = "Donald Duck";
                sports.Pages = 222;
                rock.Name = "Summer 1998";
                rock.Value = 10;
                rock.Purchased = "13.2.2008";
                rock.Artist = "Olli Lindholm";
                rock.Songs = 9;
                phone.Name = "Samsung J5";
                phone.Value = 50;
                phone.Purchased = "12.12.2016";
                phone.Manufacturer = "Samsung";
                phone.Size = 4.5;
                List<Bookshelf> stuff = new List<Bookshelf>();
                stuff.Add(sports);
                stuff.Add(rock);
                stuff.Add(phone);
                foreach (var item in stuff)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
