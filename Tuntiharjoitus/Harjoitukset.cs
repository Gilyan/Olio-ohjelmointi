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
            //TestaaKiuas();            // tehty
            //TestaaPesukone();
            TestaaTelevisio();
            //TestaaVehicle();          // tehty
        }

        /**********************************************
        *      Tehtävä 1 - Kiuas-luokan testaus       *
        **********************************************/
        static void TestaaKiuas()
        {
            Kiuas kiuas = new Kiuas();  // Luodaan Kiuas-olio

            kiuas.OnkoPaalla = true;    // Laitetaan kiuas lämpenemään
            kiuas.Lampotila = 90;       // Asetetaan lämpöä
            kiuas.Ilmankosteus = 50;    // Asetetaan ilmankosteutta

            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPaalla);     // Tulostetaan tiedot näytölle
            Console.WriteLine("Kiuakaan lämpötila {0}", kiuas.Lampotila);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Ilmankosteus);

            kiuas.Ilmankosteus = 101;   // Testatataan ilmankosteutta, asetetaan yli raja-arvon

            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Ilmankosteus);
        }

        /**********************************************
        *     Tehtävä 2 - Pesukone-luokan testaus     *
        **********************************************/
        static void TestaaPesukone()
        {

        }

        /*********************************************
        *    Tehtävä 3 - Televisio-luokan testaus    *
        **********************************************/
        static void TestaaTelevisio()
        {
            Televisio televisio = new Televisio();          // Luodaan Televisio-olio

            televisio.OnkoPaalla = true;                    // Laitetaan tv päälle
            televisio.Kanava = 3;                           // Asetetaan kanava
            televisio.Aanenvoimakkuus = 20;                 // Asetetaan äänenvoimakkuus

            televisio.PrintData();

            televisio.VaihdaKanavaa();                      // Vaihdetaan kanavaa

            televisio.LisaaAanta();                         // Lisää äänenvoimakkuutta yhdellä

            televisio.PrintData();

            televisio.VahennaAanta();                       // Vähentää äänenvoimakkuutta yhdellä
            televisio.VahennaAanta();
            televisio.VahennaAanta();
            televisio.VahennaAanta();

            televisio.PrintData();

            televisio.SuljeTV();                            // Suljetaan TV
            televisio.PrintData();
        }

        /**********************************************
        *      Tehtävä 4 - Vehicle-luokan testaus     *
        **********************************************/      
        static void TestaaVehicle()     
        {
            Vehicle Jagulaari = new Vehicle();

            Jagulaari.Name = "Jaguar";
            Jagulaari.Speed = 200;
            Jagulaari.Color = "Red";

            Jagulaari.PrintData();

            Console.WriteLine(Jagulaari.ToString());
        }
    }
}
