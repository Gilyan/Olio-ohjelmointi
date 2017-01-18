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
            //TestaaHissi();            // Tehtävä 1
            TestaaVahvistin();        // Tehtävä 2

        }

        /**********************************************
        *      Tehtävä 1 - Hissi-olion testausta      *
        **********************************************/
        static void TestaaHissi()
        {
            Hissi hissi = new Hissi();          // Luodaan Hissi-olio

            while (true)                        // Ohjelma päättyy, jos syöttää jotain muuta kuin int
            {
                int kerros = 0;
                Console.Write("Mikä kerros? (1-5) > ");
                string rivi = Console.ReadLine();

                bool tulos = int.TryParse(rivi, out kerros);        

                if (tulos)
                {
                    hissi.Kerros = kerros;      // arvo --> toimitetaan luokkaohjelmalle

                    if (kerros < 1)
                    {
                        kerros = 1;
                        Console.WriteLine("Kerros on liian iso! Kerros on nyt {0}.", kerros);
                    }

                    else if (kerros > 5)
                    {
                        kerros = 5;
                        Console.WriteLine("Kerros on liian iso! Kerros on nyt {0}.", kerros);
                    }

                    else if (kerros > 0 && kerros < 6)
                    {
                        Console.WriteLine("Kerros on nyt " + kerros);
                    }
                }

                else break;
            }
        }

        /**********************************************
        *    Tehtävä 2 - Vahvistin-olion testausta    *
        **********************************************/
        static void TestaaVahvistin()
        {
            Vahvistin vahvistin = new Vahvistin();          // Luodaan Vahvistin-olio

            while (true)                                    // Ohjelma päättyy, jos syöttää jotain muuta kuin int
            {
                int aani = 0;
                Console.Write("Set volume (0-100) > ");
                string rivi = Console.ReadLine();

                bool tulos = int.TryParse(rivi, out aani);

                if (tulos)
                {
                    vahvistin.Aanenvoimakkuus = aani;       // arvo --> toimitetaan luokkaohjelmalle

                    if (aani < 0)
                    {
                        aani = 0;
                        Console.WriteLine("Too low volume -> Volume is set to minimum: {0}!", aani);
                    }

                    else if (aani > 100)
                    {
                        aani = 100;
                        Console.WriteLine("Too high volume -> Volume is set to maximum: {0}!", aani);
                    }

                    else if (aani >= 0 && aani <= 100)
                    {
                        Console.WriteLine("Volume is set to " + aani);
                    }
                }

                else break;
            }
        }
    }
}
