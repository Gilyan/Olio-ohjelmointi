/* **************************************
Harjoitellaan get- ja set -aksessorien käyttöä.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosi { get; set; }
        public string Vari { get; set; }
        public Kulkuneuvo() { }
        public override string ToString()
        {
            return Nimi + ", malli: " + Malli + ", valmistusvuosi: " + Vuosi + ", väri: " + Vari;
        }
    }
    class Polkupyora : Kulkuneuvo
    {
        public bool OnkoVaihteet { get; set; }
        public string VaihteistonNimi { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", vaihteisto: " + OnkoVaihteet + ", vaihteiston nimi: " + VaihteistonNimi + " euroa";
        }
    }
    class Vene : Kulkuneuvo
    {
        public string Tyyppi { get; set; }
        public int Istuinpaikka { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", tyyppi: " + Tyyppi + ", istuinpaikat: " + Istuinpaikka;
        }
    }
}
