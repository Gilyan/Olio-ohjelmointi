/* **************************************
Harjoitellaan koostamista.

Luotu 23.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;
using System.Collections.Generic;

namespace JAMK.IT
{
    public class Rengas
    {
        public string Merkki { get; set; }
        public string Tyyppi { get; set; }
        public string Rengaskoko { get; set; }
        public Rengas(string model, string type, string size)
        {
            Merkki = model;
            Tyyppi = type;
            Rengaskoko = size;
        }
        public override string ToString()
        {
            return "Nimi: " + Merkki + ", Malli: " + Tyyppi + ", Rengas: " + Rengaskoko;
        }
    }

    class Auto
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }

        private const int maxRenkaidenLkm = 4;
        private int renkaidenLkm = 0;

        public List<Rengas> Renkaat { get; }

        public Auto()
        {
            Renkaat = new List<Rengas>();
        }
        public void LisaaRengas(Rengas rengas)
        {
            if (renkaidenLkm < maxRenkaidenLkm)
            {
                Renkaat.Add(rengas);
                renkaidenLkm++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", rengas.Merkki, Nimi);
            }
            else
            {
                Console.WriteLine("Ei enää renkaita, kiitos!");
            }
        }
        public override string ToString()
        {
            string tulosta = "\nAutossa " + Nimi + " malli: " + Malli + ", renkaat:";
            foreach (Rengas r in Renkaat)
            {
                if (r != null) tulosta += "\n- " + r.ToString();
            }
            return tulosta;
        }
    }
}
