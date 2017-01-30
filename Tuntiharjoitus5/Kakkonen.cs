/* **************************************
Harjoitellaan poikkeuksien käyttämistä ja tiedostoon kirjoittamista ja lukemista.

Luotu 30.1.2017

Toiminta: Ohjelma joka lukee yksinkertaisesta tekstitiedosto nimet.txt henkilöitten nimiä ja 
kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy.

Kopioi (tai luo itse vastaava tiedosto) D:\Temp -kansioon ja ohjelmoi koodisi tarkistamaan 
onko em. hakemistossa tiedostoa. Käytä File.Exist-metodia. Huomioi myös muut mahdolliset 
poikkeukset, joita tiedoston käsittely voi aiheuttaa.

Bonustehtävä: Lajittele nimet aakkosjärjestykseen ennen tulostusta.

Esimerkkitulostus:

  Löytyi 20 riviä, ja 9 nimeä.
  Nimi Aappo esiintyy 4 kertaa
  Nimi Benkku esiintyy 2 kertaa
  Nimi Jaakko esiintyy 3 kertaa
  Nimi Wille esiintyy 4 kertaa
  Nimi Sebastian esiintyy 1 kertaa
  Nimi Cecilia esiintyy 2 kertaa
  Nimi Netta esiintyy 2 kertaa
  Nimi Matias esiintyy 1 kertaa
  Nimi Otto esiintyy 1 kertaa
  Press any key to continue . . .

Minttu Mäkäläinen K8517 @ JAMK 
************************************** */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Tehtava2
    {
        public static void Teht2()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] nimet = new string[5];             // Luodaan taulukko viidelle nimelle

            for (int i = 0; i < nimet.Length; i++)
            {
                Console.Write("Anna nimi: ");           // Kysytään 5 nimeä
                nimet[i] = (Console.ReadLine());
            }

            System.IO.StreamWriter outputFile = null;   // Luodaan tyhjä kirjoitustiedosto

            try
            {
                outputFile = new System.IO.StreamWriter(mydocpath + @"\nimet.txt");
                foreach (string rivi in nimet)
                    outputFile.WriteLine(rivi);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Access to the path 'z:\nimet.txt' is denied.
            }

            finally
            {
                if (outputFile != null)         // check for null because OpenWrite might have failed
                {
                    outputFile.Close();         // Suljetaan kirjoitustiedosto
                }
            }

            try         // Luetaan tiedostosta ja tulostetaan näytölle
            {
                string[] luettu = System.IO.File.ReadAllLines(mydocpath + @"\nimet.txt");

                System.Console.WriteLine("Tiedoston nimet.txt sisältö : ");
                foreach (string line in luettu)
                {
                    Console.WriteLine(line);    // Tulostetaan haetut rivit
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löydetty (FileNotFoundException)");
            }

        }
    }

}
