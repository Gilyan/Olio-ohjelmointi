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
                TestaaNoppa();              // Tehtävä 1 - 
                //TestaaOstokset();           // Tehtävä 2 - 
                //TestaaKalat();              // Tehtävä 3 - 
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
                int arvo = 0;

                Noppa dice = new Noppa { Arvo = 0 };

                arvo = dice.HeitaNoppaa();

                Console.WriteLine("Silmäluku: {0}", arvo);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
