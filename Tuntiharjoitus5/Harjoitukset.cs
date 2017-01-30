/* **************************************
Tuntiharjoituksille pääohjelma.

Luotu 30.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using JAMK.IT;                          // Helpottaa meidän luokkien löytämistä
using System;
using System.Collections.Generic;
using System.IO;

namespace JAMK.IT.Harjoituksia
{
    class Harjoitukset
    {
        static void Main(string[] args)
        {
            //Tehtava1.Teht1();           // Tehtävä 1 - tehty
            TestaaKakkonen();           // Tehtävä 2 - 
            //Tehtava3.Teht3();           // Tehtävä 3 - 
            //Tehtava4.Teht4();           // Tehtävä 4 - 
        }

        /**********************************************
        *      Tehtävä 2 - Tehtava 2:n testausta      *
        **********************************************/
        static void TestaaKakkonen()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Nimet nimi = new Nimet();

            try         // Luetaan tiedostosta
            {
                string[] luettu = System.IO.File.ReadAllLines(mydocpath + @"\tehtava2.txt");

                foreach (string line in luettu)
                {
                    nimi.LisaaNimi(new Nimi() { HaettuNimi = line });
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löydetty (FileNotFoundException)");
            }

            nimi.LaskeNimet();
            Console.WriteLine("Tiedostossa tehtava2.txt on {0} erilaista nimeä : ", nimi.LaskeNimet();

            Console.Write( "Tiedoston tehtava2.txt sisältö : ");    // Tulostetaan sisältö sellaisenaan
            Console.WriteLine(nimi.ToString());

            Console.ReadLine();
            Console.WriteLine("Tiedoston tehtava2.txt sisältö aakkostettuna: ");    // Tulostetaan sisältö aakkostettuna

        }
    }
}
