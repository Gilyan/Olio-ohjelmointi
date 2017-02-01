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
            //TestaaHissi();            // Tehtävä 1 - tehty
            //TestaaVahvistin();        // Tehtävä 2 - tehty
            //TestaaHenkilotiedot();    // Tehtävä 3 - tehty
            //TestaaKulkuneuvot();      // Tehtävä 4 - tehty
            //TestaaRadio();            // Tehtävä 5 - tehty
            //TestaaKirjahylly();       // Tehtävä 6 - tehty
            //TestaaPaivakirja();       // Tehtävä 7 - tehty
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

        /**********************************************
        *  Tehtävä 3 - Henkilotiedot-olion testausta  *
        **********************************************/
        static void TestaaHenkilotiedot()
        {
            Employee employee = new Employee();

            employee.Name = "Dina Dyykkari";
            employee.Profession = "Roskakuski";
            employee.Salary = 2500;

            Boss boss = new Boss();

            boss.Name = "Bertta Bomo";
            boss.Profession = "Esimies";
            boss.Salary = 3000;
            boss.Car = "Volvo";
            boss.Bonus = 200;

            Console.WriteLine(employee.ToString());
            Console.WriteLine(boss.ToString());
        }

        /**********************************************
        *   Tehtävä 4 - Kulkuneuvot-olion testausta   *
        **********************************************/
        static void TestaaKulkuneuvot()
        {
            Kulkuneuvo kulkuneuvo = new Kulkuneuvo();

            kulkuneuvo.Nimi = "Yksisarvinen";
            kulkuneuvo.Malli = "hevonen";
            kulkuneuvo.Vuosi = 2010;
            kulkuneuvo.Vari = "valkoinen";

            Polkupyora pyora = new Polkupyora();

            pyora.Nimi = "Ainotar 7-v";
            pyora.Malli = "Helkama";
            pyora.Vuosi = 2017;
            pyora.Vari = "punainen";
            pyora.OnkoVaihteet = true;
            pyora.VaihteistonNimi = "Shimano Nexus 7 - V";

            Vene venho = new Vene();

            venho.Nimi = "Titanic";
            venho.Malli = "Suomi 420";
            venho.Vuosi = 2005;
            venho.Vari = "sininen";
            venho.Tyyppi = "soutuvene";
            venho.Istuinpaikka = 6;

            Console.WriteLine(kulkuneuvo.ToString());
            Console.WriteLine(pyora.ToString());
            Console.WriteLine(venho.ToString());
        }

        /**********************************************
         *     Tehtävä 5 - Radio-olion testausta      *
        **********************************************/
        static void TestaaRadio()
        {
            Radio radio = new Radio();

            radio.OnkoPaalla = true;        // Asetetaan radio päälle

            while (radio.OnkoPaalla == true)
            {
                int aanenvoimakkuus = 0;
                int taajuus = 0;
                string vastaus = "";
                bool testi, testi2;

                Console.WriteLine("Radion tila : {0}", radio.OnkoPaalla);

                Console.Write("Mikä äänenvoimakkuus? (1-9) > ");
                vastaus = Console.ReadLine();

                testi = int.TryParse(vastaus, out aanenvoimakkuus);

                if (testi)
                {
                    radio.Aanenvoimakkuus = aanenvoimakkuus;

                    if (aanenvoimakkuus < 1)
                    {
                        aanenvoimakkuus = 1;
                        Console.WriteLine("Liian pieni arvo, äänenvoimakkuus on nyt {0}.", aanenvoimakkuus);
                    }

                    else if (aanenvoimakkuus > 9)
                    {
                        aanenvoimakkuus = 9;
                        Console.WriteLine("Liian suuri arvo, äänenvoimakkuus on nyt {0}.", aanenvoimakkuus);
                    }

                    else if (aanenvoimakkuus >= 1 && aanenvoimakkuus <= 9)
                    {
                        Console.WriteLine("Äänenvoimakkuus on nyt " + aanenvoimakkuus);
                    }
                }

                Console.Write("Haluttu taajuus? (2000-26000 Hz) > ");
                vastaus = Console.ReadLine();

                testi2 = int.TryParse(vastaus, out taajuus);

                if (testi2)
                {
                    radio.Taajuus = taajuus;

                    if (taajuus < 2000)
                    {
                        taajuus = 2000;
                        Console.WriteLine("Liian pieni arvo, taajuus on nyt {0}.", taajuus);
                    }

                    else if (taajuus > 26000)
                    {
                        taajuus = 26000;
                        Console.WriteLine("Liian suuri arvo, taajuus on nyt {0}.", taajuus);
                    }

                    else if (taajuus >= 2000 && taajuus <= 26000)
                    {
                        Console.WriteLine("Taajuus on nyt " + taajuus);
                    }
                }

                Console.WriteLine("Vieläkö kuunnellaan radiota? joo / ei");
                vastaus = Console.ReadLine();

                if (vastaus == "joo")
                { radio.OnkoPaalla = true; }

                else { radio.OnkoPaalla = false; }

                Console.WriteLine("Radion tila : {0}", radio.OnkoPaalla);
            }
        }

        /**********************************************
         *   Tehtävä 6 - Kirjahylly-olion testausta   *
        **********************************************/
        static void TestaaKirjahylly()
        {
            Kirja kirja = new Kirja();

            kirja.MikaTavara = "Kirja";
            kirja.Nimi = "Aku Ankka";
            kirja.Tekija = "Disney";
            kirja.Vuosi = 2016;
            kirja.Sivumaara = 32;

            Musiikki levy = new Musiikki();

            levy.MikaTavara = "CD-levy";
            levy.Nimi = "Repullinen hittejä";
            levy.Tekija = "Eppu Normaali";
            levy.Vuosi = 1996;
            levy.Kappaleita = 24;

            Tablet tabuletti = new Tablet();

            tabuletti.MikaTavara = "Tablet";
            tabuletti.Nimi = "Galaxy Tab A 10.1";
            tabuletti.Tekija = "Samsung";
            tabuletti.Vuosi = 2016;
            tabuletti.Vari = "musta";
            tabuletti.NaytonKoko = 10.1F;

            Console.WriteLine(kirja.ToString());
            Console.WriteLine(levy.ToString());
            Console.WriteLine(tabuletti.ToString());
        }

        /**********************************************
         *  Tehtävä 7 - Paivakirja-olion testausta    *
        **********************************************/
        static void TestaaPaivakirja()
        {
            int laji = 0;
            string vastaus;

            Console.Write("Mikä laji? 1 = pyöräily, 2 = painonnosto > ");
            vastaus = Console.ReadLine();

            bool tulos = int.TryParse(vastaus, out laji);

            if (tulos)
            {
                switch (laji)
                {
                    case 1:
                        Pyoraily pyoraily = new Pyoraily();
                        pyoraily.Laji = "Pyöräily";

                        Console.Write("Anna päivämäärä (p.kk.v) > ");
                        pyoraily.Paivamaara = Console.ReadLine();

                        Console.Write("Anna poljettu matka metreissä > ");
                        pyoraily.Matka = int.Parse(Console.ReadLine());

                        Console.Write("Anna käytetty aika minuuteissa > ");
                        pyoraily.Aika = int.Parse(Console.ReadLine());

                        Console.WriteLine(pyoraily.ToString());
                        break;

                    case 2:
                        Painonnosto painonnosto = new Painonnosto();
                        painonnosto.Laji = "Painonnosto";

                        Console.Write("Anna päivämäärä (p.kk.v) > ");
                        painonnosto.Paivamaara = Console.ReadLine();

                        Console.Write("Anna nostettu paino > ");
                        painonnosto.Paino = int.Parse(Console.ReadLine());

                        Console.Write("Anna toistojen määrä > ");
                        painonnosto.Toisto = int.Parse(Console.ReadLine());

                        Console.WriteLine(painonnosto.ToString());
                        break;

                    default:
                        Console.WriteLine("Mene ulos siitä.");
                        break;
                }
            }

            else Console.WriteLine("Lopetetaan");
        }
    }
}
