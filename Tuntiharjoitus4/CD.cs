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
    public class CD
    {
        public string Nimi { get; set; }
        public string Artisti { get; set; }

        public List<Biisi> Biisilista;

        public CD()
        {
            Biisilista = new List<Biisi>();
        }
        public void LisaaBiisi(Biisi kappale)
        {
            Biisilista.Add(kappale);
        }

        public override string ToString()
        {
            string tulosta = "Levyn tiedot \nNimi: " + Nimi + "\nArtisti: " + Artisti + "\nKappaleet: ";
            foreach (Biisi h in Biisilista)
            {
                tulosta += "\n- " + h.ToString();
            }
            return tulosta;
        }
    }
    public class Biisi
    {
        public string Nimi { get; set; }
        public override string ToString()
        {
            return Nimi;
        }
    }
}
