/* **************************************
Harjoitellaan get- ja set -aksessorien käyttöä.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Vahvistin
    {
        int aani;
        public int Aanenvoimakkuus
        {
            get
            {
                return aani;
            }
            set
            {
                if (value >= 0 && value <= 100)
                { aani = value; }

            }
        }
    }
}
