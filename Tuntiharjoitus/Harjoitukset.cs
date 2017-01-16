/* **************************************
Tuntiharjoituksille pääohjelma.

Luotu 16.1.2017

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
            TestaaKiuas();
        }
        static void TestaaKiuas()       // Tehtävä 1 - Kiuas-luokan testaus
        {
            Kiuas kiuas = new Kiuas();  // Luodaan Kiuas-olio

            kiuas.OnkoPaalla = true;    // Laitetaan kiuas lämpenemään
            kiuas.Lampotila = 90;       // Asetetaan lämpöä
            kiuas.Ilmankosteus = 50;    // Asetetaan ilmankosteutta

            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPaalla);     // Tulostetaan tiedot näytölle
            Console.WriteLine("Kiuakaan lämpötila {0}", kiuas.Lampotila);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Ilmankosteus);
        }
    }
}
