/* **************************************
Kertaamista.

Toiminta: Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä. Ostettavalta tuotteelta 
riittää käsitellä nimi ja hinta. Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi 
List-tietorakenteeseen muutamia Product-luokan oliota. Tulosta lopuksi kokoelman sisältö.

Esimerkkitulostus:

All products in collection:
- product : Milk 1,4 e
- product : Beer 2,2 e
- product : Butter 3,2 e
- product : Cheese 4,2 e

Luotu 1.2.2017

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
    class Tuote
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }

        public override string ToString()
        {
            return Nimi + " " + Hinta + " e";
        }
    }

    class Ostoskori
    {
        private List<Tuote> tuotteet;

        public List<Tuote> Kori
        {
            get { return tuotteet; }
        }

        public Ostoskori()
        {
            tuotteet = new List<Tuote>();
        }

        public void LisaaTuote(Tuote item)
        {
            tuotteet.Add(item);
        }

        public override string ToString()
        {
            string tulosta = "Ostoskorin sisältö";
            foreach (Tuote h in Kori)
            {
                tulosta += "\n- " + h.ToString();
            }
            return tulosta;
        }
    }
}
