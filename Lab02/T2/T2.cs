﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra02 T2
 * Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
 */

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int [] taulukko = new taulukko [5];  // taulukon määrittely ja alustus;
                Console.WriteLine("Give first number: ");
                taulukko[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give second number: ");
                taulukko[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give first number: ");
                taulukko[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give first number: ");
                taulukko[3] = int.Parse(Console.ReadLine());
                Console.WriteLine("Give first number: ");
                taulukko[4] = int.Parse(Console.ReadLine());

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(taulukko[i]);
                }
                // pyydetään käyttäjältä luvut
                // tulostetaan annetut luvut käänteisessä järjestyksessä
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}