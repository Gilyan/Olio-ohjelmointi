/* **************************************
Kertaamista.

Toiminta: Toteuta sovellus, jossa voit hallita kalastukseen liittyviä tietoja. Ohjelman pitää 
pystyä käsittelemään: saadun kalan perustiedot 
(laji, pituus ja paino)
kalastajan perustiedot (nimi, puhelinnumero)
saadun kalapaikan perustiedot (nimi ja paikka). 

Pohdi tarvittava luokkarakenne UML-kaaviona. Toteuta pääohjelmassa kalastaja ja muutamia kaloja. 
Tulosta lopuksi kalarekisterin sisältö.

Tulosta kalarekisteri siten, että kalat ovat suuruusjärjestykessä (painavin ensin).

Esimerkkitulostus:

    A new fisherman added to register:
     - Fisherman: Kirsi Kernel Phone: 020-12345678

    Fisher : Kirsi Kernel got a new fish
     - specie : pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä

    Fisher : Kirsi Kernel got a new fish
     - specie: salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland

    All fishes in register:

    Fisherman Kirsi Kernel has got following fishes:

     - specie: pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä

     - specie: salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland

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
    class Kala
    {
        public string Laji { get; set; }
        public string Pituus { get; set; }
        public string Paino { get; set; }

        public override string ToString()
        {
            return Laji + ", pituus " + Pituus + ", paino " + Paino;
        }
    }

    class Kalastaja
    {
        public string Nimi { get; set; }
        public string Puhelinnumero { get; set; }

        public override string ToString()
        {
            return Nimi + ", " + Puhelinnumero;
        }
    }

    class Kalapaikka
    {
        public string Nimi { get; set; }
        public string Sijainti { get; set; }

        public override string ToString()
        {
            return Nimi + ", " + Sijainti;
        }
    }

    class Kalareissu
    {
        public List<Kala> Kalat = new List<Kala>();
        public Kalastaja KukaKalasti = new Kalastaja();
        public Kalapaikka Paikka = new Kalapaikka();

        public void LisaaKala(Kala fisu)
        {
            Kalat.Add(fisu);
            Console.WriteLine("{0} sai kalan {1}", KukaKalasti.Nimi, fisu);
        }

        public void LisaaKalastaja(Kalastaja fisustaja)
        {
            this.KukaKalasti = fisustaja;
            Console.WriteLine("Kalajastaja {0} lisätty.", KukaKalasti.Nimi);
        }

        public void LisaaSijainti(Kalapaikka lokaatio)
        {
            this.Paikka = lokaatio;
            Console.WriteLine("Sijainti: {0}, {1}", Paikka.Nimi, Paikka.Sijainti);
        }

        public override string ToString()
        {
            string tulosta = "\nKALAREISSUN TIEDOT \n" + Paikka;
            tulosta += "\n" + KukaKalasti + " sai seuraavia kaloja: ";
            foreach (Kala r in Kalat)
            {
                if (r != null) tulosta += "\n- " + r.ToString();
            }
            return tulosta;
        }
    }
}
