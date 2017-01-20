/* **************************************
Harjoitellaan get- ja set -aksessorien käyttöä.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    class Tavara
    {
        public string MikaTavara { get; set; }
        public string Nimi { get; set; }
        public string Tekija { get; set; }
        public int Vuosi { get; set; }

        public Tavara() { }           // Oletuskonstruktori

        public override string ToString()
        {
            return MikaTavara + ": " + Nimi + ", " + Vuosi;
        }
    }

    class Kirja : Tavara
    {
        public int Sivumaara { get; set; }

        public override string ToString()
        {
            return base.ToString() + ". Kirjoittanut: " + Tekija + ", sivuja: " + Sivumaara;
        }
    }

    class Musiikki : Tavara
    {
        public int Kappaleita { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", " + Tekija + ", biisejä: " + Kappaleita;
        }
    }

    class Tablet : Tavara
    {
        public string Vari { get; set; }
        public float NaytonKoko { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", " + Vari + ", " + NaytonKoko + " tuumaa.";
        }
    }
}
