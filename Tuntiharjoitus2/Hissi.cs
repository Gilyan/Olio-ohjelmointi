/* **************************************
Harjoitellaan get- ja set -aksessorien käyttöä.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Hissi
    {
        int kerros;
        int minKerros = 1;
        int maxKerros = 5;
        public int Kerros
        {
            get
            { return kerros; }
            set
            {
                if (value >= minKerros && value <= maxKerros)
                { kerros = value; }
            }
        }
    }
}
