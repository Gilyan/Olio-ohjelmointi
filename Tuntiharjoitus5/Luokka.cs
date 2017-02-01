/* **************************************
Harjoitellaan koostamista.

Luotu 23.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;
using System.Collections.Generic;

namespace JAMK.IT
{
    class Luokka
    {
        public List<Oppilas> Oppilaat = new List<Oppilas>();        // Aggregation = luokka Luokka sisältää luokan Oppilas olioita
        public Opettaja OpeNyt = new Opettaja();
        public string HuoneNro { get; set; }

        public void LisaaOppilas(Oppilas opiskelija)
        {
            Oppilaat.Add(opiskelija);
            Console.WriteLine("Opiskelija {0} lisätty luokkaan {1}", opiskelija.Nimi, HuoneNro);
        }

        public void LisaaOpettaja(Opettaja OpeNyt)
        {
            this.OpeNyt = OpeNyt;
            Console.WriteLine("Opettaja {0} lisätty luokkaan {1}", OpeNyt.Nimi, HuoneNro);
        }

        public override string ToString()
        {
            string tulosta = "\nLuokassa " + HuoneNro + " opettaa " + OpeNyt + ". Oppilaina on ";
            foreach (Oppilas r in Oppilaat)
            {
                if (r != null) tulosta += "\n- " + r.ToString();
            }
            return tulosta;
        }
    }

    public class Oppilas
    {
        public string Nimi { get; set; }
        public string OpNro { get; set; }

        public override string ToString()
        {
            return "Nimi: " + Nimi + ", opiskelijanumero: " + OpNro;
        }
    }

    public class Opettaja
    {
        public string Nimi { get; set; }
        public double Palkka { get; set; }

        public override string ToString()
        {
            return "Nimi: " + Nimi + ", palkka: " + Palkka;
        }
    }
}
