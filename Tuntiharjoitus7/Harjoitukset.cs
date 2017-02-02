/* **************************************
Tuntiharjoituksille pääohjelma.

Luotu 30.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using JAMK.IT;                          // Helpottaa meidän luokkien löytämistä
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Harjoituksia
{
    class Harjoitukset
    {
        static void Main(string[] args)
        {
            try
            {
                //Tehtava1.Teht1();           // Tehtävä 1 - tehty
                TestaaKakkonen();           // Tehtävä 2 - 
                //Tehtava3.Teht3();           // Tehtävä 3 - 
                //Tehtava4.Teht4();           // Tehtävä 4 - 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**********************************************
        *      Tehtävä 2 - Tehtava 2:n testausta      *
        **********************************************/
        static void TestaaKakkonen()
        {
            // Tee ohjelma, joka lukee yksinkertaisesta tekstitiedostosta henkilöitten nimiä ja 
            // kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy. Ohjelmoi koodisi 
            // tarkistamaan onko hakemistossa tiedostoa. Käytä File.Exist - metodia. Huomioi myös muut 
            // mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.
            // Bonustehtävä: Lajittele nimet aakkosjärjestykseen ennen tulostusta.

            try
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                List<string> nimet = System.IO.File.ReadAllLines(mydocpath + @"\tehtava2.txt").ToList();

                Console.WriteLine(File.Exists(mydocpath + @"\tehtava2.txt") ? "File exists." : "File does not exist.");

                var maara = nimet
                .GroupBy(x => x)
                .Select(g => new { key = g.Key, count = g.Count() });

                nimet.Sort();       // Lajitellaan nimet aakkosjärjestykseen

                Console.WriteLine("Tiedostosta tehtava2 löytyi yhteensä {0} nimeä, joista {1} erilaista.", nimet.Count, maara.Count());

                foreach (var group in maara)
                {
                    Console.WriteLine("Nimi {0} esiintyy {1} kertaa", group.key, group.count);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
