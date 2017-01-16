/* **************************************
Harjoitellaan luokkien ja ominaisuuksien tekoa ja käyttöä.

Luotu 16.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Jaakaappi
    {
        public int Lampotila { get; set; }
        public int Tayttoaste { get; set; }
        public bool OnkoPaalla { get; set; }
        public bool OviAuki { get; set; }

        public void Tulosta()
        {
            string tila, tila2;

            if (OnkoPaalla == true)     // Jos virta on päällä sekä ovi kiinni --> kaikki ok
            {
                tila = "päällä";
                Lampotila = 10;
            }
            else
            {
                Lampotila += 5;
                tila = "pois päältä";
            }

            if (OviAuki == true)      // Jos jääkaapin ovi on auki sekä virrat päällä
            {
                tila2 = "auki";
                Lampotila += 5;
            }
            else
            {
                tila2 = "kiinni";
            }

            if (OviAuki == true && OnkoPaalla == false)      // Jos ovi on auki ja virrat eivät ole päällä
            {
                Lampotila = 22;
                Tayttoaste = 0;
            }

            Console.WriteLine("***********************************");
            Console.WriteLine("Jääkaapin tila: {0}", tila);
            Console.WriteLine("Oven tila: {0}", tila2);
            Console.WriteLine("Täyttöaste: {0} %", Tayttoaste);
            Console.WriteLine("Lämpötila: {0} celsiusta", Lampotila);
            Console.WriteLine("***********************************");
        }

        public void VahennaLampoa()
        {
            Lampotila -= 1;
        }

        public void LisaaLampoa()
        {
            Lampotila += 1;
        }

        public void OstaRuokaa()
        {
            Console.WriteLine("Kuinka paljon jääkaappi täyttyi?");
            Tayttoaste += int.Parse(Console.ReadLine());

            if (Tayttoaste > 100)
            {
                Console.WriteLine("Kaikki ei mahdu jääkaappiin, sinun täytyy syödä osa.");
                Tayttoaste = 100;
            }
        }

        public void SyoRuokaa()
        {
            Console.WriteLine("Kuinka paljon jääkaappi tyhjeni?");
            Tayttoaste -= int.Parse(Console.ReadLine());

            if (Tayttoaste <= 0)
            {
                Console.WriteLine("Jääkaappi on ihan tyhjä, käy kaupassa.");
                Tayttoaste = 0;
            }
        }
    }
}