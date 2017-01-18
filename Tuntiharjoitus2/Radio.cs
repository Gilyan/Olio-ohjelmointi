/* **************************************
Harjoitellaan get- ja set -aksessorien käyttöä.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Radio
    {
        public int voimakkuus;
        public readonly int minVoimakkuus = 0;      // Voi lukea pääohjelmasta, mutta ei säätää
        public readonly int maxvoimakkuus = 9;
        public readonly float minTaajuus = 2000.0F;
        public readonly float maxTaajuus = 26000.0F;
        public bool OnkoPaalla { get; set; }

        public int Aanenvoimakkuus
        {
            get
            { return voimakkuus; }
            set
            {
                if (value >= minVoimakkuus && value <= maxvoimakkuus)
                { voimakkuus = value; }
            }
        }
        public int Taajuus
        {
            get
            { return voimakkuus; }
            set
            {
                if (value >= minTaajuus && value <= maxTaajuus)
                { voimakkuus = value; }
            }
        }
    }
}
