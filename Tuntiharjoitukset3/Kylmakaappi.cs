/* **************************************
Harjoitellaan perintää ja koostamista.

Luotu 23.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;
using System.Collections.Generic;

namespace JAMK.IT
{
    class Kylmakaappi
    {
        public List<Sidukka> pullot = new List<Sidukka>();
        public Makkara maggara = new Makkara();

        public void LisaaSidua(Sidukka plo)
        {
            pullot.Add(plo);
            Console.WriteLine("Jääkaappiin lisätty {0} {1} l", plo.Nimi, plo.Koko);
        }

        public void LisaaRuokaa(Makkara hk)
        {
            this.maggara = hk;
            Console.WriteLine("Jääkaappiin lisätty {0} {1} g", hk.Nimi, hk.Paino);
        }

        public override string ToString()
        {
            string tulosta = "\nJääkaapista löytyy valon lisäksi ";
            foreach (Sidukka r in pullot)
            {
                if (r != null) tulosta += "\n- " + r.ToString();
            }
            tulosta += "\n- " + maggara.ToString();
            return tulosta;
        }
    }

    public class Sidukka
    {
        public string Nimi { get; set; }
        public double Koko { get; set; }

        public Sidukka(string nimi, double koko)
        {
            Nimi = nimi;
            Koko = koko;
        }

        public override string ToString()
        {
            return Nimi + " " + Koko + " l";
        }
    }

    public class Makkara
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }

        /*public Makkara(string nimi, int paino)        // miksei toimi
        {
            Nimi = nimi;
            Paino = paino;
        }*/

        public override string ToString()
        {
            return Nimi + " " + Paino + " g";
        }
    }
}
