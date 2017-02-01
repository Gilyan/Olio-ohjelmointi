/* **************************************
Harjoitellaan listan käyttämistä.

Luotu 28.1.2017

Minttu Mäkäläinen K8517 @ JAMK 
************************************** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Ika + ", pelaajanumero: " + Numero;
        }
    }

    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        private List<Pelaaja> pelaajat;

        public List<Pelaaja> Tiimi
        {
            get { return pelaajat; }
        }

        public Joukkue()
        {
            pelaajat = new List<Pelaaja>();
        }

        public void LisaaPelaaja(Pelaaja jyp)
        {
            pelaajat.Add(jyp);
        }

        public Pelaaja HaePelaaja(int index)
        {
            if (index < pelaajat.Count)
            {
                return pelaajat.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public Pelaaja HaePelaajaNumerolla(int index)
        {
            foreach (Pelaaja jyp in pelaajat)
            {
                if (jyp.Numero == index)
                {
                    return jyp;
                }
            }
            return null;
        }

        public Pelaaja PoistaPelaaja(int numero)
        {
            pelaajat.RemoveAll(x => x.Numero == numero);
            return null;
        }
    }
}
