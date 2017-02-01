/* **************************************
Harjoitellaan luokkien ja ominaisuuksien tekoa ja käyttöä.

Luotu 16.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Kiuas
    {
        public bool OnkoPaalla { get; set; }
        public float Lampotila { get; set; }

        float kosteus;
        public float Ilmankosteus               // Kosteus voi olla välillä 0-100
        {
            get { return kosteus; }
            set
            {
                kosteus = value;
                if (kosteus < 0 || kosteus > 100)
                {
                    kosteus = 0;
                }
            }
        }     

    }
}
