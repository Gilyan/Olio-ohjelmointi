/* **************************************
Harjoitellaan luokkien ja ominaisuuksien tekoa ja käyttöä.

Luotu 16.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Televisio
    {
        public bool OnkoPaalla { get; set; }
        public int Kanava { get; set; }
        public int Aanenvoimakkuus { get; set; }

        public void VaihdaKanavaa()
        {
            Console.WriteLine("Anna uusi kanava: ");
            Kanava = int.Parse(Console.ReadLine());
        }

        public void PrintData()
        {
            string tila;

            if (OnkoPaalla == true)
            {
                tila = "päällä";
            }
            else
            {
                Kanava = 0;
                Aanenvoimakkuus = 0;
                tila = "pois päältä";
            }

            Console.WriteLine("***********************************");
            Console.WriteLine("Television tila: {0}", tila);
            Console.WriteLine("Näytettävä kanava: {0}", Kanava);
            Console.WriteLine("Äänenvoimakkuus: {0}", Aanenvoimakkuus);
            Console.WriteLine("***********************************");
        }

        public void LisaaAanta()
        {
            Aanenvoimakkuus += 1;
        }

        public void VahennaAanta()
        {
            Aanenvoimakkuus -= 1;
        }

        public void SuljeTV()
        {
            OnkoPaalla = false;
        }

    }
}
