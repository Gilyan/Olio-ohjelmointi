/* **************************************
Harjoitellaan poikkeuksien käyttämistä ja tiedostoon kirjoittamista ja lukemista.

Luotu 30.1.2017

Toiminta: Ohjelma joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) 
ja sulkee tiedoston. Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston 
sisältö riveittäin. Huomioi mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.

Esimerkkitulostus:

    Give a text line (enter ends) : Matti
    Give a text line (enter ends) : Teppo
    Give a text line (enter ends) : Seppo
    Give a text line (enter ends) : Jorma
    Give a text line (enter ends) :
    
    Contents of T1TextLines.txt:
    Matti
    Teppo
    Seppo
    Jorma

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
    public class Tehtava1
    {
        public static void Teht1()
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
                Console.WriteLine(ex.Message);  // Access to the path is denied.
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
