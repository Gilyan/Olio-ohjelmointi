/* **************************************
Harjoitellaan get- ja set -aksessorien käyttöä.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    class Paivakirja
    {
        public string Paivamaara { get; set; }
        public string Laji { get; set; }
        
        public Paivakirja() { }           // Oletuskonstruktori

        public override string ToString()
        {
            return Paivamaara + ": " + Laji;
        }
    }

    class Pyoraily : Paivakirja
    {
        public float kilometri;

        public int Aika { get; set; }
        public float Matka
        {
            get { return kilometri; }
            set { kilometri = value / 1000; }
        }

        public override string ToString()
        {
            return base.ToString() + ": poljettu " + Matka + " km " + Aika + " minuutissa";
        }
    }

    class Painonnosto : Paivakirja
    {
        public int Paino { get; set; }
        public int Toisto { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": nostettu " + Paino + " kg painoa " + Toisto + " kertaa";
        }
    }
}
