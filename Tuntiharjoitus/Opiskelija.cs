/* **************************************
Harjoitellaan luokkien ja ominaisuuksien tekoa ja käyttöä.

Luotu 16.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Opiskelija
    {
        public string Nimi { get; set; }
        public string Osoite { get; set; }
        public string Opiskelijanumero { get; set; }
        public string Puhelinnumero { get; set; }
        public string Kurssit { get; set; }

        public void Tulosta()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("OPISKELIJAN TIEDOT");
            Console.WriteLine("Nimi: {0}, opiskelijanumero: {1}", Nimi, Opiskelijanumero);
            Console.WriteLine("Osoite: {0}", Osoite);
            Console.WriteLine("Puhelinnumero: {0}", Puhelinnumero);
            Console.WriteLine("Kurssit: {0}", Kurssit);
            Console.WriteLine("********************************************************");
        }

        public void VaihdaNimi()
        {
            Console.WriteLine("Anna uusi nimi: ");
            Nimi = Console.ReadLine();
        }

        public void VaihdaOsoite()
        {
            Console.WriteLine("Anna uusi osoite: ");
            Osoite = Console.ReadLine();
        }

        public void VaihdaPuhelinnumero()
        {
            Console.WriteLine("Anna uusi puhelinnumero: ");
            Puhelinnumero = Console.ReadLine();
        }

        public void LisaaKurssi()
        {
            Console.WriteLine("Lisättävän kurssin nimi: ");
            Kurssit = Kurssit + ", " + Console.ReadLine();
        }
    }
}