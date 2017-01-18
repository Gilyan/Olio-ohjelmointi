/* **************************************
Tuntiharjoituksille pääohjelma.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using JAMK.IT;                          // Helpottaa meidän luokkien löytämistä
using System;

namespace Tuntiharjoitukset
{
    class Harjoitukset
    {
        static void Main(string[] args)
        {
            TestaaHissi();            // Tehtävä 1

        }

        /**********************************************
        *      Tehtävä 1 - Hissi-olion testausta      *
        **********************************************/
        static void TestaaHissi()
        {
            Hissi hissi = new Hissi();  // Luodaan Hissi-olio

            while (true)
            {
                int kerros = 0;
                Console.Write("Mikä kerros? (1-5) > ");
                string rivi = Console.ReadLine();

                bool tulos = int.TryParse(rivi, out kerros);        // out kerros --> toimitetaan luokkaohjelmalle

                if (tulos)
                {
                    hissi.Kerros = kerros;
                }

                else break;
            }
        }
    }
}
