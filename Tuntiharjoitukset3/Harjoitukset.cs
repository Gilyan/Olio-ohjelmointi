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
            TestaaKylmakaappi();        // Tehtävä 2
            //TestaaNisakas();            // Tehtävä 3
            //Testaadsafdsfds();          // Tehtävä 4
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
        *    Tehtävä 2 - Vahvistin-olion testausta    *
        **********************************************/
        static void TestaaKylmakaappi()
        {
            Maito maito = new Maito ("Maito", "24.1.2017", "20.1.2017, true)

        }

        /**********************************************
        *  Tehtävä 3 - Henkilotiedot-olion testausta  *
        **********************************************/
        static void TestaaNisakas()
        {

        }

        /**********************************************
        *   Tehtävä 4 - Kulkuneuvot-olion testausta   *
        **********************************************/
        static void Testaadsafdsfds()
        {

        }
    }
}
