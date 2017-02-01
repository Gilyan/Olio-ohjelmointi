/* **************************************
Harjoitellaan luokkien ja ominaisuuksien tekoa ja käyttöä.

Luotu 16.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Pesukone
    {
        public bool OnkoPaalla { get; set; }
        public int Lampotila { get; set; }

        int ohjelma;
        public int Pesuohjelma               // Kosteus voi olla välillä 0-100
        {
            get { return ohjelma; }
            set { ohjelma = value; }
        }

        string tila;

        public void Tulosta()
        {
            if (OnkoPaalla == true)
            {
                tila = "päällä";
            }
            else
            {
                tila = "pois päältä";
            }

            Console.WriteLine("***********************************");
            Console.WriteLine("Pyykkikoneen tila: {0}", tila);
            Console.WriteLine("Pesuohjelma: {0}", Pesuohjelma);
            Console.WriteLine("Lämpötila: {0}", Lampotila);
            Console.WriteLine("***********************************");
        }

        public void PesePyykki()
        {
            if (OnkoPaalla == true)
            {
                switch (Pesuohjelma)
                {
                    case 1:
                        Console.WriteLine("Valittu kirjopyykki {0} asteessa", Lampotila);
                        Console.WriteLine("HURRUR SURRUR");
                        break;
                    case 2:
                        Console.WriteLine("Valittu valkopyykki {0} asteessa", Lampotila);
                        Console.WriteLine("HURRUR SURRUR");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tarkista, että virta on päällä ja yritä uudelleen.");
            }

        }
    }
}
