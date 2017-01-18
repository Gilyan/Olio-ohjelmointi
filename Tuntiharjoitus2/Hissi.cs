/* **************************************
Harjoitellaan luokkien ja ominaisuuksien tekoa ja käyttöä.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Hissi
    {
        int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                kerros = value;
                if (kerros < 1)
                {
                    Console.WriteLine("Kerros on liian pieni!");
                    kerros = 1;
                }

                if (kerros > 5)
                {
                    Console.WriteLine("Kerros on liian iso!");
                    kerros = 5;
                }

                if (kerros > 0 && kerros < 6)
                {
                    Console.WriteLine("Kerros on nyt " + kerros);
                }
            }
        }
    }
}
