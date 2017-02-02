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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
                //TestaaKakkonen();           // Tehtävä 2 - tehty
                //TestaaKolmonen();           // Tehtävä 3 - tehty
                TestaaNelonen();           // Tehtävä 4 - tehty
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**********************************************
        *            Tehtävä 2:n testausta            *
        **********************************************/
        static void TestaaKakkonen()
        {
            // Tee ohjelma, joka lukee yksinkertaisesta tekstitiedostosta henkilöitten nimiä ja 
            // kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy. Ohjelmoi koodisi 
            // tarkistamaan onko hakemistossa tiedostoa. Huomioi myös muut mahdolliset poikkeukset, 
            // joita tiedoston käsittely voi aiheuttaa.
            // Bonustehtävä: Lajittele nimet aakkosjärjestykseen ennen tulostusta.

            try
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                List<string> nimet = System.IO.File.ReadAllLines(mydocpath + @"\tehtava2.txt").ToList();

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

        /**********************************************
        *            Tehtävä 3:n testausta            *
        **********************************************/
        static void TestaaKolmonen()
        {
            // Tee ohjelma, joka kysyy käyttäjältä lukuja (joko kokonaisluku tai reaaliluku) ja tallenna 
            // kokonaisluvut eri tiedostoon kuin reaaliluvut. Sovellus tulee lopettaa, jos käyttäjä ei 
            // syötä kokonais- tai reaalilukua. Tarkista tiedostojen sisältö jollain tekstieditorilla.

            System.IO.StreamWriter outputFile = null;
            System.IO.StreamWriter outputFile2 = null;

            try
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                string syote = "";
                int kokonaisluku = 0;
                double liukuluku = 0.0F;

                List<int> koko = new List<int>();           // Lista kokonaisluvuille
                List<double> liuku = new List<double>();    // Lista liukuluvuille

                do
                {
                    Console.Write("Syötä luku > ");
                    syote = Console.ReadLine();

                    try
                    {
                        kokonaisluku = int.Parse(syote);        // Koitetaan muuntaa kokonaisluvuksi
                        koko.Add(kokonaisluku);
                    }

                    catch (FormatException)
                    {
                        try
                        {
                            liukuluku = double.Parse(syote);    // Koitetaan muuntaa liukuluvuksi
                            liuku.Add(liukuluku);
                        }

                        catch (FormatException)
                        {
                            break;
                        }
                    }

                } while (syote.Length != 0);

                outputFile = new System.IO.StreamWriter(mydocpath + @"\kokonaisluvut.txt");
                Console.Write("Syötetyt kokonaisluvut: ");
                foreach (int item in koko)
                {
                    Console.Write("   " + item);        // Tulostetaan näytölle
                    outputFile.WriteLine(item);         // Kirjoitetaan tekstitiedostoon
                }

                outputFile2 = new System.IO.StreamWriter(mydocpath + @"\liukuluvut.txt");
                Console.Write("\nSyötetyt liukuluvut: ");
                foreach (float item in liuku)
                {
                    Console.Write("   " + item);        // Tulostetaan näytölle
                    outputFile2.WriteLine(item);        // Kirjoitetaan tekstitiedostoon
                }

                Console.WriteLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }

                if (outputFile2 != null)
                {
                    outputFile2.Close();
                }
            }
        }

        /**********************************************
        *            Tehtävä 4:n testausta            *
        **********************************************/
        static void TestaaNelonen()
        {
            // Tee ohjelma, jossa voidaan käsitellä TV-ohjelmia. TV-ohjelman tietoina tulee käsitellä: 
            // ohjelman nimi, kanava (jolta ohjelma tulee), alku- ja loppuaika sekä pienimuotoinen 
            // infoteksti ohjelmasta. Luo pääohjelmassa muutamia TV-ohjelmaolioita (tiedot voit 
            // alustaa suoraan koodista, ei tarvitse kysyä käyttäjältä) ja tallenna ne 
            // levylle. Mieti käytätkö jotain tietorakennetta apunasi. Toteuta ohjelmaan myös 
            // tiedostonlukeminen ja tulosta TV-oliot näkyville.

            System.IO.StreamWriter outputFile = null;

            try
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                Ohjelma cartoon = new Ohjelma();

                cartoon.OhjelmanNimi = "My Little Pony";
                cartoon.Kanava = 4;
                cartoon.Alkuaika = "10.50";
                cartoon.Loppuaika = "11.20";
                cartoon.Infoteksti = "Puhuvia poneja.";

                Ohjelma news = new Ohjelma();

                news.OhjelmanNimi = "Viiden uutiset";
                news.Kanava = 3;
                news.Alkuaika = "17.00";
                news.Loppuaika = "17.30";
                news.Infoteksti = "Tärkeitä uutisia.";

                Ohjelma documentary = new Ohjelma();

                documentary.OhjelmanNimi = "Avara luonto";
                documentary.Kanava = 1;
                documentary.Alkuaika = "13.30";
                documentary.Loppuaika = "14.30";
                documentary.Infoteksti = "Kissan elämää.";

                // Olio täytyy sarjallistaa, jotta se voidaan tallentaa tiedostoon. 
                // Serialization = olion tiedot muutetaan tavumuotoiseksi virraksi (stream of byte), jotta ne voidaan siirtää tiedostoon

                /**** KIRJOITTAMINEN ****/
                // Avataan kirjoittamista varten
                Stream kirjoitaTiedostoon = new FileStream(mydocpath + @"ohjelmat.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                
                IFormatter formatter = new BinaryFormatter();       // Käytetään binäärimuotoa

                formatter.Serialize(kirjoitaTiedostoon, cartoon);       // Kirjoitetaan tiedostoon
                formatter.Serialize(kirjoitaTiedostoon, news);          // Kirjoitetaan tiedostoon
                formatter.Serialize(kirjoitaTiedostoon, documentary);   // Kirjoitetaan tiedostoon

                kirjoitaTiedostoon.Close();                         // Suljetaan tiedosto

                /**** LUKEMINEN ****/
                // Avataan lukemista varten
                Stream lueTiedostosta = new FileStream(mydocpath + @"ohjelmat.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                    
                Ohjelma readCartoon = (Ohjelma)formatter.Deserialize(lueTiedostosta);       // Luetaan tiedostosta ja muunnetaan objektiksi

                Console.WriteLine("{0} alkaa kanavalla {1} kello {2} ja päättyy kello {3}. Ohjelman kuvaus: {4}",       // Näytölle
                    readCartoon.OhjelmanNimi, readCartoon.Kanava, readCartoon.Alkuaika, readCartoon.Loppuaika, readCartoon.Infoteksti);

                Ohjelma readNews = (Ohjelma)formatter.Deserialize(lueTiedostosta);          // Luetaan tiedostosta ja muunnetaan objektiksi

                Console.WriteLine("{0} alkaa kanavalla {1} kello {2} ja päättyy kello {3}. Ohjelman kuvaus: {4}",       // Näytölle
                    readNews.OhjelmanNimi, readNews.Kanava, readNews.Alkuaika, readNews.Loppuaika, readNews.Infoteksti);

                Ohjelma readDoc = (Ohjelma)formatter.Deserialize(lueTiedostosta);           // Luetaan tiedostosta ja muunnetaan objektiksi

                Console.WriteLine("{0} alkaa kanavalla {1} kello {2} ja päättyy kello {3}. Ohjelman kuvaus: {4}",       // Näytölle
                    readDoc.OhjelmanNimi, readDoc.Kanava, readDoc.Alkuaika, readDoc.Loppuaika, readDoc.Infoteksti);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
        }
    }
}