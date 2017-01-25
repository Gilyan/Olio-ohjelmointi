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
            //TestaaRekisteri();          // Tehtävä 1 - 
            //TestaaCD();                 // Tehtävä 2 - 
            //TestaaKorttipakka();        // Tehtävä 3 - 
            //TestaaPelaajat();           // Tehtävä 4 - 
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

        }

        /**********************************************
        *      Tehtävä 3 - Korttipakan testausta      *
        **********************************************/
        static void TestaaKorttipakka()
        {

        }

        /**********************************************
        *        Tehtävä 4 - Pelaajien testausta      *
        **********************************************/
        static void TestaaPelaajat()
        {


        }
    }
}
