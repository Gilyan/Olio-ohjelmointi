/* **************************************
Opettajan kanssa yhdessä tehty henkilörekisteri.

Luotu 25.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;
using System.Collections.Generic;       // Täältä löytyy yleiskäyttöiset kokoelmat
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Henkilo                       // Sisältää henkilön ominaisuuksia
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hetu { get; set; }
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Hetu;
        }
    }
    class Henkilot                      // Sisältää henkilön tietoja ryhmässä
    {
        private List<Henkilo> henkilot;
        public List<Henkilo> Henkilolista
        {
            get { return henkilot; }
        }
        public Henkilot()
        {
            henkilot = new List<Henkilo>();
        }
        public void LisaaHenkilo(Henkilo hlo)
        {
            henkilot.Add(hlo);
        }
        public Henkilo HaeHenkilo(int index)
        {
            if (index < henkilot.Count)
            {
                return henkilot.ElementAt(index);
            }
            else
            {
                return null;
            }
        }
        public Henkilo HaeHenkiloHetulla(string hetu)
        {
            foreach (Henkilo hlo in henkilot)
            {
                if (hlo.Hetu == hetu)
                {
                    return hlo;
                }
            }
            return null;
        }
    }
}
