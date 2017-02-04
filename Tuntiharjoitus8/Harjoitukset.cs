/* **************************************
Tuntiharjoituksille pääohjelma.

Luotu 1.2.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using JAMK.IT;                          // Helpottaa meidän luokkien löytämistä
using System;
using System.Collections.Generic;
using System.IO;

namespace JAMK.IT
{
    class Harjoitukset
    {
        static void Main(string[] args)
        {
            try
            {
                //TestaaNoppa();              // Tehtävä 1 - tehty
                //TestaaOstokset();           // Tehtävä 2 - tehty
                TestaaKalat();              // Tehtävä 3 - tehty
                //TestaaKuviot();             // Tehtävä 4 - 
                //TestaaLaskutoimitukset();   // Tehtävä 5 - 
                //TestaaOstoksetJaTestaus();  // Tehtävä 6 - 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**********************************************
        *     Tehtävä 1 - Noppaohjelman testausta     *
        **********************************************/
        static void TestaaNoppa()
        {
            try
            {
                int arvo = 0, heitot = 0, yhteensa = 0;
                int yksi = 0, kaksi = 0, kolme = 0, nelja = 0, viisi = 0, kuusi = 0;
                double keskiarvo;
                string heitto;

                Noppa dice = new Noppa { Arvo = 0 };

                Console.WriteLine("Montako kertaa heitetään > ");
                heitto = Console.ReadLine();

                try
                {
                    heitot = int.Parse(heitto);        // Koitetaan muuntaa kokonaisluvuksi

                    for (int i = 0; i < heitot; i++)
                    {
                        arvo = dice.HeitaNoppaa();

                        switch (arvo)
                        {
                            case 1: { yksi++; break; }
                            case 2: { kaksi++; break; }
                            case 3: { kolme++; break; }
                            case 4: { nelja++; break; }
                            case 5: { viisi++; break; }
                            case 6: { kuusi++; break; }
                        }

                        yhteensa += arvo;
                    }

                    keskiarvo = (double)yhteensa / (double)heitot;

                    Console.WriteLine("Heittoja : {0}", heitot);
                    Console.WriteLine("Yhteensä : {0}", yhteensa);
                    Console.WriteLine("Keskiarvo : {0:F2}", keskiarvo);
                    Console.WriteLine("1 : {0} heittoa", yksi);
                    Console.WriteLine("2 : {0} heittoa", kaksi);
                    Console.WriteLine("3 : {0} heittoa", kolme);
                    Console.WriteLine("4 : {0} heittoa", nelja);
                    Console.WriteLine("5 : {0} heittoa", viisi);
                    Console.WriteLine("6 : {0} heittoa", kuusi);
                }

                catch (FormatException)
                {
                    Console.WriteLine("Eipä tainnut olla kokonaisluku.");
                } 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**********************************************
        *      Tehtävä 2 - Ostoskorin testausta       *
        **********************************************/
        static void TestaaOstokset()
        {
            try
            {
                Ostoskori kori = new Ostoskori();

                kori.LisaaTuote(new Tuote { Nimi = "Maitopurkki 1l", Hinta = 1.45 });
                kori.LisaaTuote(new Tuote { Nimi = "Jauheliha 400g", Hinta = 3.85 });
                kori.LisaaTuote(new Tuote { Nimi = "Spagetti 1kg", Hinta = 1.00 });
                kori.LisaaTuote(new Tuote { Nimi = "Talouspaperi", Hinta = 4.35 });
                kori.LisaaTuote(new Tuote { Nimi = "Shampoo 200ml", Hinta = 3.20 });

                Console.WriteLine(kori.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**********************************************
        *     Tehtävä 3 - Kalatehtävän testausta      *
        **********************************************/
        static void TestaaKalat()
        {
            try
            {
                Kalareissu jkl = new Kalareissu();

                // Luodaan sijainti
                Kalapaikka paikka = new Kalapaikka { Nimi = "Jyväsjärvi", Sijainti = "Jyväskylä" };

                jkl.LisaaSijainti(paikka);

                // Luodaan kalastaja
                Kalastaja fisherman = new Kalastaja { Nimi = "Donald Trump", Puhelinnumero = "012 345 5678" };

                jkl.LisaaKalastaja(fisherman);

                // Luodaan kaloja
                Kala haikala = new Kala { Laji = "Valkohai", Pituus = "7,5m", Paino = 1800 };
                Kala valas = new Kala { Laji = "Miekkavalas", Pituus = "6,1m", Paino = 5100 };
                Kala delfiini = new Kala { Laji = "Pullonokkadelfiini", Pituus = "2,9m", Paino = 280 };

                jkl.LisaaKala(haikala);
                jkl.LisaaKala(valas);
                jkl.LisaaKala(delfiini);

                Console.WriteLine(jkl.ToString());



                Console.WriteLine(jkl.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
