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
            //TestaaKiuas();            // Tehtävä 1 - tehty
            //TestaaPesukone();         // Tehtävä 2 - tehty
            //TestaaTelevisio();        // Tehtävä 3 - tehty
            //TestaaVehicle();          // Tehtävä 4 - tehty
            //TestaaOpiskelija();       // Tehtävä 5 - tehty
            //TestaaJaakaappi();        // Tehtävä 6 - tehty
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
            Pesukone pesukone = new Pesukone();

            pesukone.OnkoPaalla = true;        // Laitetaan pesukone päälle
            pesukone.Lampotila = 40;
            pesukone.Pesuohjelma = 2;

            pesukone.Tulosta();
            pesukone.PesePyykki();

            pesukone.OnkoPaalla = false;        // Pesukone pois päältä

            pesukone.Tulosta();
            pesukone.PesePyykki();

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
            Vehicle jagulaari = new Vehicle();

            jagulaari.Name = "Jaguar";
            jagulaari.Speed = 200;
            jagulaari.Color = "Red";

            jagulaari.PrintData();

            Console.WriteLine(jagulaari.ToString());
        }

        /**********************************************
        *    Tehtävä 5 - Opiskelija-luokan testaus    *
        **********************************************/
        static void TestaaOpiskelija()
        {
            Opiskelija[] opiskelija = new Opiskelija[5];

            for (int i = 0; i < 5; i++)                // Alustetaan taulukko
                {
                    opiskelija[i] = new Opiskelija();
            }

            // Luodaan 5 testiopiskelijaa taulukkoon

            opiskelija[0].Nimi = "Erkki Erämies";
            opiskelija[0].Opiskelijanumero = "S1234";
            opiskelija[0].Osoite = "Maantie 1, 12345 Jontikka";
            opiskelija[0].Puhelinnumero = "040 123 4566";
            opiskelija[0].Kurssit = "Matematiikka, Viestintä";

            opiskelija[1].Nimi = "Jaana Erämies";
            opiskelija[1].Opiskelijanumero = "S1235";
            opiskelija[1].Osoite = "Maantie 1, 12345 Jontikka";
            opiskelija[1].Puhelinnumero = "040 123 5467";
            opiskelija[1].Kurssit = "Ohjelmointi, Liikunta";

            opiskelija[2].Nimi = "Jonne Junkkari";
            opiskelija[2].Opiskelijanumero = "L1634";
            opiskelija[2].Osoite = "Ojanpohja 6, 12300 Jontikka";
            opiskelija[2].Puhelinnumero = "050 773 8866";
            opiskelija[2].Kurssit = "Matematiikka, Ohjelmointi, Tietokannat";

            opiskelija[3].Nimi = "Paavo Pesusieni";
            opiskelija[3].Opiskelijanumero = "D1138";
            opiskelija[3].Osoite = "Merenpohja, 00000 Meri";
            opiskelija[3].Puhelinnumero = "-";
            opiskelija[3].Kurssit = "Uiminen, Kalalogia, Meritähdet ja niiden käyttäytyminen";

            opiskelija[4].Nimi = "Pikachu";
            opiskelija[4].Opiskelijanumero = "A9876";
            opiskelija[4].Osoite = "Puunkolo 12, Metsä";
            opiskelija[4].Puhelinnumero = "045 908 4539";
            opiskelija[4].Kurssit = "Elektroniikka, Sähkövoimatekniikka, Piirien käristäminen";

            Console.Clear();
            for (int i = 0; i < 5; i++)
            { opiskelija[i].Tulosta(); }

            Console.WriteLine("Minkä opiskelijan tietoja muutetaan? (0-4)");
            int muutos = int.Parse(Console.ReadLine());

            opiskelija[muutos].VaihdaNimi();
            opiskelija[muutos].VaihdaOsoite();
            opiskelija[muutos].VaihdaPuhelinnumero();

            opiskelija[muutos].Tulosta();

            Console.WriteLine("Mille opiskelijalle lisätään kurssi? (0-4)");
            muutos = int.Parse(Console.ReadLine());
            opiskelija[muutos].LisaaKurssi();

            Console.WriteLine("Tiedot päivitetty!");
            opiskelija[muutos].Tulosta();
        }

        /**********************************************
        *     Tehtävä 6 - Jaakaappi-luokan testaus    *
        **********************************************/
        static void TestaaJaakaappi()
        {
            Jaakaappi jaakaappi = new Jaakaappi();

            jaakaappi.OnkoPaalla = true;        // Jääkaappi on päällä
            jaakaappi.OviAuki = false;          // Ovi on kiinni
            jaakaappi.Lampotila = 10;
            jaakaappi.Tayttoaste = 60;

            jaakaappi.Tulosta();

            jaakaappi.OstaRuokaa();
            Console.WriteLine("Jääkaapin täyttöaste on nyt {0} prosenttia.", jaakaappi.Tayttoaste);

            jaakaappi.SyoRuokaa();
            Console.WriteLine("Jääkaapin täyttöaste on nyt {0} prosenttia.", jaakaappi.Tayttoaste);

            jaakaappi.OviAuki = true;           // Jääkaapin ovi on auki
            Console.WriteLine("Jääkaapin oven tila: {0}.", jaakaappi.OviAuki);
            Console.WriteLine("Jääkaapin lämpötila {0} astetta.", jaakaappi.Lampotila);

            jaakaappi.OnkoPaalla = false;       // Jääkaappi ei ole päällä
            Console.WriteLine("Jääkaapin tila: {0}.", jaakaappi.OnkoPaalla);
            Console.WriteLine("Jääkaapin lämpötila {0} astetta.", jaakaappi.Lampotila);

            jaakaappi.OviAuki = false;
            jaakaappi.OnkoPaalla = true;        // Jääkaappi on taas päällä

            jaakaappi.VahennaLampoa();
            jaakaappi.VahennaLampoa();
            jaakaappi.VahennaLampoa();
            jaakaappi.VahennaLampoa();
            Console.WriteLine("Jääkaapin lämpötila {0} astetta.", jaakaappi.Lampotila);
        }
    }
}
