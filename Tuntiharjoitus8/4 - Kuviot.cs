/* **************************************
Kertaamista.

Toiminta: Toteuta sovellus, jolla voidaan käsitellä erilaisia kuviota (esim. Circle ja Rectangle). 
Laadi erillinen abstrakti Shape-luokka, josta muut kuviot peryityvät. Määrittele Shape-luokan 
ominaisuutena kuvion nimi (Name) ja abstraktit Area- ja Circumference-metodit (pinta-ala ja 
ympärysmitta). Peri Circle- ja Rectangle-luokat Shape-luokasta ja toteuta Area- ja 
Circumference-metodit. Luo Shapes-luokka ja sen sisälle List-tietorakenne, jonne voit aina 
lisätä kuvioita. Toteuta pääohjelma, jossa käytät Shapes-luokkaa, luo muutamia eri kuviota ja 
lisää ne Shapes-luokassa olevaan List-tietorakenteeseen. Käy pääohjelmassa lopuksi läpi 
Shapes-luokan List-tietorakenne ja tulosta kaikki sen sisältämät kuviot.

Esimerkkitulostus:

    Circle Radius=1 Area=3,14 Circumference=7,28
    Circle Radius=2 Area=12,57 Circumference=8,28
    Circle Radius=3 Area=28,27 Circumference=9,28
    Rectangle Width=10 Height=20 Area=200,00 Circumference=60,00
    Rectangle Width=20 Height=30 Area=600,00 Circumference=100,00
    Rectangle Width=40 Height=50 Area=2000,00 Circumference=180,00

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
    abstract class Shape        // Kuvio - pääluokka
    {
        public string Nimi { get; set; }
        public abstract void Area();            // Abstrakti metodi, pinta-ala
        public abstract void Circumference();   // Abstrakti metodi, ympärysmitta

        public override string ToString()
        {
            return "Kuvio: " + Nimi;
        }
    }

    class Shapes        // Kuvioille lista
    {
        public List<Shape> Kuviot = new List<Shape>();

        public void LisaaKuvio(Shape kuvio)
        {
            Kuviot.Add(kuvio);
        }

        public override string ToString()
        {
            string tulosta = "Listassa on nämä kuviot: ";
            foreach (Shape r in Kuviot)
            {
                if (r != null) tulosta += "\n- " + r.ToString();
            }
            return tulosta;
        }
    }

    class Rectangle : Shape     // Neliö - aliluokka
    {
        double Pituus { get; set; }
        double Leveys { get; set; }
        double ala, ymparysmitta;

        public Rectangle(double pituus, double leveys)
        {
            Pituus = pituus;
            Leveys = leveys;
        }

        public override void Area()
        {
            ala = Pituus * Leveys;
            ala = Math.Round(ala, 2);
        }

        public override void Circumference()
        {
            ymparysmitta = 2*Pituus + 2*Leveys;
            ymparysmitta = Math.Round(ymparysmitta, 2);
        }

        public override string ToString()
        {
            return base.ToString() + ", pituus: " + Pituus + ", leveys: " + Leveys + ", pinta-ala: " + ala + ", ympärys: " + ymparysmitta;
        }
    }

    class Circle : Shape        // Ympyrä - aliluokka
    {
        public double Sade { get; set; }
        double ala, ymparysmitta;

        public Circle(double sade)
        {
            Sade = sade;
        }

        public override void Area()                 // Pinta-ala = πr^2
        {
            ala = (Math.PI * Math.Pow(Sade, 2));
            ala = Math.Round(ala, 2);
        }

        public override void Circumference()        // Piirin pituus = 2πr
        {
            ymparysmitta = 2 * Math.PI * Sade;
            ymparysmitta = Math.Round(ymparysmitta, 2);
        }

        public override string ToString()
        {
            return base.ToString() + ", säde: " + Sade + ", pinta-ala: " + ala + ", ympärys: " + ymparysmitta;
        }
    }


}
