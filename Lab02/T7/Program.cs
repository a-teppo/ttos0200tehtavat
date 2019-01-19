using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Labra02 T7
 * Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon.
 * Tulosta lopuksi lajitellun taulukon sisältö
 */
namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array1 = { 10, 20, 30, 40, 50 };
                int[] array2 = { 5, 15, 25, 35, 45 };
                int[] array3 = new int[10];
                int[] array4 = new int[10];

                for (int i = 0; i < 5; i++) //siirretään kaikki tiedot samaan taulukkoon
                    array3[i] = array1[i];
                for (int i = 0; i < 5; i++)
                    array3[i + 5] = array2[i];

                /*
                for (int i = 0; i < 10; i++) // kokeilu, että kaikki tiedot ovat siirtyneet
                    Console.WriteLine(array3[i]);
                */

                for (int i=0;i<10;i++) // vaihtolajittelu toimii taas
                    for (int j = i+1;j<10;j++)
                        if (array3[j]<array3[i])
                        {
                            array4[i] = array3[i];
                            array3[i] = array3[j];
                            array3[j] = array4[i];
                        }
                for(int i = 0; i < 10; i++)
                    Console.WriteLine(array3[i]);

                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
