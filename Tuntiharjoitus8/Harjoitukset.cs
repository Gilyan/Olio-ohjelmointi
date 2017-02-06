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
                //TestaaKalat();              // Tehtävä 3 - tehty
                //TestaaKuviot();             // Tehtävä 4 - tehty
                TestaaLaskutoimitukset();   // Tehtävä 5 - tehty
                //TestaaOstoksetJaTestaus();  // Tehtävä 6 - tehty
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
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**********************************************
        *     Tehtävä 4 - Kuviotehtävän testausta     *
        **********************************************/
        static void TestaaKuviot()
        {
            try
            {
                // Tehdään pari neliötä
                Rectangle nelio1 = new Rectangle(10.0, 20.0);
                nelio1.Nimi = "Neliö 1";
                nelio1.Area();
                nelio1.Circumference();

                Rectangle nelio2 = new Rectangle(25.0, 35.0);
                nelio2.Nimi = "Neliö 2";
                nelio2.Area();
                nelio2.Circumference();

                Rectangle nelio3 = new Rectangle(50.4, 6.8);
                nelio3.Nimi = "Neliö 3";
                nelio3.Area();
                nelio3.Circumference();

                // Tehdään pari ympyrää
                Circle ympyra1 = new Circle(1.0);
                ympyra1.Nimi = "Ympyrä 1";
                ympyra1.Area();
                ympyra1.Circumference();

                Circle ympyra2 = new Circle(3.5);
                ympyra2.Nimi = "Ympyrä 2";
                ympyra2.Area();
                ympyra2.Circumference();

                Circle ympyra3 = new Circle(10);
                ympyra3.Nimi = "Ympyrä 3";
                ympyra3.Area();
                ympyra3.Circumference();

                // Lisätään tehdyt kuviot listaan
                Shapes kuviot = new Shapes();

                kuviot.LisaaKuvio(nelio1);
                kuviot.LisaaKuvio(nelio2);
                kuviot.LisaaKuvio(nelio3);
                kuviot.LisaaKuvio(ympyra1);
                kuviot.LisaaKuvio(ympyra2);
                kuviot.LisaaKuvio(ympyra3);

                // Tulostetaan listan sisältö näytölle
                Console.WriteLine(kuviot.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**********************************************
        *   Tehtävä 5 - Laskutoimituksien testausta   *
        **********************************************/
        static void TestaaLaskutoimitukset()
        {
            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

                Console.Write("Numerot ovat :");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(" {0}  ", array[i]);
                }
                Console.WriteLine();

                Console.WriteLine("Keskiarvo : {0:F2}", ArrayCalcs.Average(array));
                Console.WriteLine("Pienin luku : {0:F2}", ArrayCalcs.Min(array));
                Console.WriteLine("Suurin luku : {0:F2}", ArrayCalcs.Max(array));
                Console.WriteLine("Kaikki yhteentä : {0:F2}", ArrayCalcs.Sum(array));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**********************************************
        *  Tehtävä 6 - Toisen ostostehtävän testausta *
        **********************************************/
        static void TestaaOstoksetJaTestaus()
        {
            try
            {

                Kauppareissu maijaShoppaa = new Kauppareissu();

                maijaShoppaa.Nimi = "Maija Mehiläinen";

                maijaShoppaa.LisaaTuote(new Ostos { Nimi = "Maitopurkki 1l", Hinta = 1.45, Maara = 2 });
                maijaShoppaa.LisaaTuote(new Ostos { Nimi = "Jauheliha 400g", Hinta = 3.85, Maara = 1 });
                maijaShoppaa.LisaaTuote(new Ostos { Nimi = "Spagetti 1kg", Hinta = 1.00, Maara = 3 });
                maijaShoppaa.LisaaTuote(new Ostos { Nimi = "Talouspaperi", Hinta = 4.35, Maara = 1 });
                maijaShoppaa.LisaaTuote(new Ostos { Nimi = "Shampoo 200ml", Hinta = 3.20, Maara = 2 });
                maijaShoppaa.LisaaTuote(new Ostos { Nimi = "Fazer Sininen 250g", Hinta = 2.20, Maara = 5 });

                Console.WriteLine(maijaShoppaa.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
