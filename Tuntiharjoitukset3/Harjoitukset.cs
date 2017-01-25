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
            //TestaaKylmakaappi();        // Tehtävä 2 - tehty
            //TestaaNisakas();            // Tehtävä 3 - tehty
            //TestaaLuokka();             // Tehtävä 4 - tehty
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
            Sidukka rekorderlig = new Sidukka("Rekorderlig Mansikka-Lime", 0.5);
            Sidukka kopparberg = new Sidukka("Kopparberg Mixed Fruit", 0.5);

            Makkara hookoo = new Makkara();
            hookoo.Nimi = "HK:n sininen";
            hookoo.Paino = 580;

            Kylmakaappi kaappi = new Kylmakaappi();

            kaappi.LisaaSidua(rekorderlig);
            kaappi.LisaaSidua(rekorderlig);
            kaappi.LisaaSidua(rekorderlig);
            kaappi.LisaaSidua(kopparberg);
            kaappi.LisaaSidua(kopparberg);
            kaappi.LisaaRuokaa(hookoo);

            Console.WriteLine(kaappi.ToString());
        }

        /**********************************************
        *    Tehtävä 3 - Nisäkästehtävän testausta    *
        **********************************************/
        static void TestaaNisakas()
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
            oppilas2.Nimi = "Lauri Lusmu";
            oppilas2.OpNro = "L1224";

            Oppilas oppilas3 = new Oppilas();
            oppilas3.Nimi = "Antti Alkoholisti";
            oppilas3.OpNro = "A3239";

            Opettaja opettaja = new Opettaja();
            opettaja.Nimi = "Olli Opettaja";
            opettaja.Palkka = 3000;

            Luokka atk = new Luokka();

            atk.HuoneNro = "D421";

            atk.LisaaOpettaja(opettaja);

            atk.LisaaOppilas(oppilas1);
            atk.LisaaOppilas(oppilas2);
            atk.LisaaOppilas(oppilas3);

            Console.WriteLine(atk.ToString());

        }
    }
}
