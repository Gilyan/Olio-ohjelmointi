/* **************************************
Harjoitellaan poikkeuksien käyttämistä ja tiedostoon kirjoittamista ja lukemista.

Luotu 30.1.2017

Toiminta: Ohjelma joka lukee yksinkertaisesta tekstitiedosto nimet.txt henkilöitten nimiä ja 
kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy.

Kopioi (tai luo itse vastaava tiedosto) D:\Temp -kansioon ja ohjelmoi koodisi tarkistamaan 
onko em. hakemistossa tiedostoa. Käytä File.Exist-metodia. Huomioi myös muut mahdolliset 
poikkeukset, joita tiedoston käsittely voi aiheuttaa.

Bonustehtävä: Lajittele nimet aakkosjärjestykseen ennen tulostusta.

Esimerkkitulostus:

  Löytyi 20 riviä, ja 9 nimeä.
  Nimi Aappo esiintyy 4 kertaa
  Nimi Benkku esiintyy 2 kertaa
  Nimi Jaakko esiintyy 3 kertaa
  Nimi Wille esiintyy 4 kertaa
  Nimi Sebastian esiintyy 1 kertaa
  Nimi Cecilia esiintyy 2 kertaa
  Nimi Netta esiintyy 2 kertaa
  Nimi Matias esiintyy 1 kertaa
  Nimi Otto esiintyy 1 kertaa
  Press any key to continue . . .

tehtava2.txt :

Aappo
Aappo
Otto
Aappo
Aappo
Benkku
Benkku
Jaakko
Matias
Jaakko
Netta
Jaakko
Wille
Wille
Wille
Wille
Sebastian
Cecilia
Cecilia
Cecilia
Netta

Minttu Mäkäläinen K8517 @ JAMK 
************************************** */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Nimi
    {
        public string HaettuNimi { get; set; }

        public override string ToString()
        {
            return HaettuNimi;
        }
    }
    class Nimet
    {
        private List<Nimi> nimet;
        public List<Nimi> Nimilista
        {
            get { return nimet; }
        }
        public Nimet()
        {
            nimet = new List<Nimi>();
        }
        public void LisaaNimi(Nimi nimi)
        {
            nimet.Add(nimi);
        }
        public int LaskeNimet()
        {
            int maara = nimet.Count;
            return maara;
        }
        public void LaskeErilaisetNimet()
        {
            var maara = nimet.GroupBy(x => x)
            .Select(g => new { Value = g.Key, Count = g.Count() });

            //Console.WriteLine("Löytyi yhteensä {0} nimeä, joista {1} erilaista.", nimet.Count, maara.Count);
        }
        public void Jarjesta()
        {
            nimet.Sort();
        }
        public override string ToString()
        {
            string tulosta = "";
            foreach (Nimi h in Nimilista)
            {
                tulosta += "\n- " + h.ToString();
            }
            return tulosta;
        }
    }
}
