/* **************************************
Tuntiharjoituksille pääohjelma.

Luotu 23.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using JAMK.IT;                          // Helpottaa meidän luokkien löytämistä
using System;
using System.Collections.Generic;

namespace Harjoituksia
{
    class Harjoitukset
    {
        static void Main(string[] args)
        {
            //TestaaRengas();             // Tehtävä 1 - tehty
            //TestaaKylmakaappi();        // Tehtävä 2
            //TestaaNisakas();            // Tehtävä 3 - tehty
            //TestaaLuokka();             // Tehtävä 4
        }

        /**********************************************
        *      Tehtävä 1 - Rengas-olion testausta     *
        **********************************************/
        static void TestaaRengas()
        {
            Rengas nokia = new Rengas("Nokia", "Hakkapeliitta", "205R16");

            Auto auto = new Auto();

            auto.Nimi = "Porsche";
            auto.Malli = "911";

            Console.WriteLine("Luotu uusi auto : {0} {1}", auto.Nimi, auto.Malli);
            auto.LisaaRengas(nokia);
            auto.LisaaRengas(nokia);
            auto.LisaaRengas(nokia);
            auto.LisaaRengas(nokia);

            Console.WriteLine(auto.ToString());
        }

        /**********************************************
        *      Tehtävä 2 - Kylmakaapin testausta      *
        **********************************************/
        static void TestaaKylmakaappi()
        {
            //Maito maito = new Maito ("Maito", "24.1.2017", "20.1.2017", true);          // true = on loppu

            Hedelma paaryna = new Hedelma("päärynä", "vihreä");

            Kylmakaappi kaappi = new Kylmakaappi();
            kaappi.Tavara = "hedelmä";
            kaappi.ParastaEnnen = "30.1.2017";

            Console.WriteLine("Lisätty jääkaappiin : {0}, syötävä ennen {1}", kaappi.Tavara, kaappi.ParastaEnnen);

            //kaappi.LisaaTavara(paaryna);

            //Console.WriteLine(hedelma.ToString());      // testaus
           // Console.WriteLine(maito.ToString());        // testaus
        }

        /**********************************************
        *    Tehtävä 3 - Nisäkästehtävän testausta    *
        **********************************************/
        static void TestaaNisakas()     // Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.
        {
            Ihminen ihminen = new Ihminen();
            ihminen.Ika = 50;
            ihminen.Paino = 95;
            ihminen.Pituus = 190;
            ihminen.Nimi = "Markku";
            Console.WriteLine(ihminen.ToString());
            ihminen.Liiku();

            Console.WriteLine("************************************************");

            Aikuinen aikuinen = new Aikuinen(35, 80, 170, "Jaana", "Volvo");

            Console.WriteLine(aikuinen.ToString());
            aikuinen.Liiku();
            aikuinen.Kasva();
            aikuinen.Kasva();
            aikuinen.Kasva();
            Console.WriteLine(aikuinen.ToString());

            Console.WriteLine("************************************************");

            Vauva vauva = new Vauva(1, 8, 75, "Beibe", "Pampers");
            Console.WriteLine(vauva.ToString());
            vauva.Liiku();
        }

        /**********************************************
        *         Tehtävä 4 - Luokan testausta        *
        **********************************************/
        static void TestaaLuokka()
        {
            Oppilas oppilas1 = new Oppilas();
            oppilas1.Nimi = "Janne Joutilas";
            oppilas1.OpNro = "J1234";

            Oppilas oppilas2 = new Oppilas();
            oppilas1.Nimi = "Lauri Lusmu";
            oppilas1.OpNro = "L1224";

            Oppilas oppilas3 = new Oppilas();
            oppilas1.Nimi = "Antti Alkoholisti";
            oppilas1.OpNro = "A3239";

            Opettaja opettaja = new Opettaja();
            opettaja.Nimi = "Olli Opettaja";
            opettaja.Palkka = 3000;

            Luokka atk = new Luokka();

            atk.HuoneNro = "D421";

            atk.LisaaOppilas(oppilas1);
            Console.WriteLine("Lisätty oppilas {0}, {1}", oppilas1.Nimi, oppilas1.OpNro);
            atk.LisaaOppilas(oppilas2);
            Console.WriteLine("Lisätty oppilas {0}, {1}", oppilas2.Nimi, oppilas2.OpNro);
            atk.LisaaOppilas(oppilas3);
            Console.WriteLine("Lisätty oppilas {0}, {1}", oppilas3.Nimi, oppilas3.OpNro);

            Console.WriteLine(atk.ToString());

        }
    }
}
