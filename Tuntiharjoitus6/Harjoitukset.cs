/* **************************************
Tuntiharjoituksille pääohjelma.

Luotu 25.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using JAMK.IT;                          // Helpottaa meidän luokkien löytämistä
using System;
using System.Collections.Generic;

namespace JAMK.IT.Harjoituksia
{
    class Harjoitukset
    {
        static void Main(string[] args)
        {
            //TestaaRekisteri();          // Tehtävä 1 - tehty
            //TestaaCD();                 // Tehtävä 2 - tehty
            TestaaKorttipakka();        // Tehtävä 3 - tehty - tee bonusosa, jossa sekoitetaan korttipakka
            //TestaaPelaajat();           // Tehtävä 4 - tehty
        }

        /**********************************************
        *   Tehtävä 1 - Henkilörekisterin testausta   *
        **********************************************/
        static void TestaaRekisteri()
        {
            Henkilot porukka = new Henkilot();      // Luodaan muutama testihenkilö
            Henkilo hlo1 = new Henkilo { Etunimi = "Jack", Sukunimi = "Russel", Hetu = "311270-123A" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Jane", Sukunimi = "Doe", Hetu = "210975-224C" };
            Henkilo hlo3 = new Henkilo { Etunimi = "Sue", Sukunimi = "Pegg", Hetu = "101087-6284" };

            porukka.LisaaHenkilo(hlo1);             // Lisätään henkilöt porukkaan
            porukka.LisaaHenkilo(hlo2);
            porukka.LisaaHenkilo(hlo3);

            foreach (Henkilo h in porukka.Henkilolista)     // Tulostetaan porukka näytölle
            {
                Console.WriteLine("{0}", h.ToString());
            }

            Console.Write("Anna haettava hetu > ");         // Kysy hetu ja etsi sitä vastaava henkilö näytölle
            string rivi = Console.ReadLine();

            porukka.HaeHenkiloHetulla(rivi);
            Console.WriteLine("Löytyi {0}", porukka.HaeHenkiloHetulla(rivi));
        }

        /**********************************************
        *    Tehtävä 2 - CD-harjoituksen testausta    *
        **********************************************/
        static void TestaaCD()
        {
            CD levy = new CD();
            levy.Nimi = "Rakettihitit Vol 15";
            levy.Artisti = "Smurffit";

            levy.LisaaBiisi(new Biisi { Nimi = "Smurffit tykkää" });
            levy.LisaaBiisi(new Biisi { Nimi = "Jekkusmurffin lahja" });
            levy.LisaaBiisi(new Biisi { Nimi = "Pikkasen smurffi" });
            levy.LisaaBiisi(new Biisi { Nimi = "Smurffiina kampaa" });
            levy.LisaaBiisi(new Biisi { Nimi = "Kumparemäki" });
            levy.LisaaBiisi(new Biisi { Nimi = "Huopaa ja souda" });
            levy.LisaaBiisi(new Biisi { Nimi = "Hiljentykää " });
            levy.LisaaBiisi(new Biisi { Nimi = "Smurffi surffaa " });
            levy.LisaaBiisi(new Biisi { Nimi = "Ahmattismurffi " });
            levy.LisaaBiisi(new Biisi { Nimi = "Voiku " });
            levy.LisaaBiisi(new Biisi { Nimi = "Hyvänsmurffisuus " });
            levy.LisaaBiisi(new Biisi { Nimi = "Smurffilorut " });
            levy.LisaaBiisi(new Biisi { Nimi = "Smurffityyli " });

            Console.WriteLine(levy.ToString());
        }

        /**********************************************
        *      Tehtävä 3 - Korttipakan testausta      *
        **********************************************/
        static void TestaaKorttipakka()
        {
            List<Kortti> kortti = new List<Kortti>();

            // Määritellään maat ja numerot
            string[] maat = { "Hertta", "Ruutu", "Pata", "Risti" };
            string[] numerot = { "ässä", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jätkä", "kuningatar", "kuningas" };

            foreach (string maa in maat)        // Jokaiselle maalle lisätään 13 korttia
            {
                for (int i = 0; i <= 12; i++)
                {
                    kortti.Add(new Kortti { Maa = maa, Numero = numerot[i] });
                }
            }

            Console.WriteLine("Korttipakka: "); // Printataan koko roska näytölle
            foreach (Kortti k in kortti)
            {
                Console.WriteLine(k.ToString());
            }

        }

        /**********************************************
        *        Tehtävä 4 - Pelaajien testausta      *
        **********************************************/
        static void TestaaPelaajat()
        {
            int valinta = 5;

            Joukkue sakki = new Joukkue();
            sakki.Kotikaupunki = "Jyväskylä";
            sakki.Nimi = "JYP";

            // Lisäillään muutama pelaaja
            sakki.LisaaPelaaja(new Pelaaja { Etunimi = "Juho", Sukunimi = "Olkinuora", Ika = 26, Numero = 45 });
            sakki.LisaaPelaaja(new Pelaaja { Etunimi = "Markus", Sukunimi = "Ruusu", Ika = 19, Numero = 97 });
            sakki.LisaaPelaaja(new Pelaaja { Etunimi = "Pekka", Sukunimi = "Tuokkola", Ika = 33, Numero = 83 });
            sakki.LisaaPelaaja(new Pelaaja { Etunimi = "Olli", Sukunimi = "Aitola", Ika = 24, Numero = 60 });
            sakki.LisaaPelaaja(new Pelaaja { Etunimi = "Joona", Sukunimi = "Erving", Ika = 22, Numero = 53 });
            sakki.LisaaPelaaja(new Pelaaja { Etunimi = "Niklas", Sukunimi = "Friman", Ika = 23, Numero = 20 });
            sakki.LisaaPelaaja(new Pelaaja { Etunimi = "Jaakko", Sukunimi = "Jokinen", Ika = 23, Numero = 16 });

            do
            {
                Console.WriteLine("Lopeta = 0 ");
                Console.WriteLine("Lisää pelaaja = 1 ");
                Console.WriteLine("Poista pelaaja = 2 ");
                Console.WriteLine("Tulosta pelaajat = 3 ");
                Console.Write("Anna valinta > ");
                valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 1: // Lisää pelaaja

                        Pelaaja hlo = new Pelaaja();

                        Console.Write("Pelaajan etunimi > ");
                        hlo.Etunimi = Console.ReadLine();

                        Console.Write("Pelaajan sukunimi > ");
                        hlo.Sukunimi = Console.ReadLine();

                        Console.Write("Pelaajan ikä > ");
                        hlo.Ika = int.Parse(Console.ReadLine());

                        Console.Write("Pelaajan numero > ");
                        hlo.Numero = int.Parse(Console.ReadLine());

                        sakki.LisaaPelaaja(hlo);
                        break;

                    case 2: // Poista pelaaja
                        Console.Write("Poistettavan pelaajan numero > ");
                        int nro = int.Parse(Console.ReadLine());

                        sakki.HaePelaajaNumerolla(nro);
                        Console.Write("Löytyi {0}, poistetaanko? (k/e) > ", sakki.HaePelaajaNumerolla(nro));
                        string poisto = Console.ReadLine();

                        if (poisto == "e")
                        { break; }

                        if (poisto == "k")
                        {
                            sakki.PoistaPelaaja(nro);
                            break;
                        }

                        else
                        { break; }

                        break;

                    case 3: // Tulosta pelaajat
                        Console.WriteLine("Joukkueen tiedot \nNimi: " + sakki.Nimi + "\nKotikaupunki: " + sakki.Kotikaupunki + "\nPelaajat: ");

                        foreach (Pelaaja h in sakki.Tiimi)
                        {
                            Console.WriteLine("{0}", h.ToString());
                        }
                        break;

                    case 0: // Lopeta
                        Console.WriteLine("Lopetetaan..");
                        break;

                }
            } while (valinta != 0);
        }
    }
}
