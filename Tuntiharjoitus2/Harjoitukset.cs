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
            //TestaaVahvistin();        // Tehtävä 2
            //TestaaHenkilotiedot();    // Tehtävä 3
            TestaaKulkuneuvot();      // Tehtävä 4
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
    }
}
