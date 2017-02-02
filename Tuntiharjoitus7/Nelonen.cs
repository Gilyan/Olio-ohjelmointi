/* **************************************
Harjoitellaan poikkeuksien käyttämistä ja tiedostoon kirjoittamista ja lukemista.

Luotu 30.1.2017

Toiminta: Ohjelma jossa voidaan käsitellä TV-ohjelmia. 
TV-ohjelman tietoina tulee käsitellä: ohjelman nimi, kanava (jolta ohjelma tulee), 
alku- ja loppuaika sekä pienimuotoinen infoteksti ohjelmasta. Luo pääohjelmassa 
muutamia TV-ohjelmaolioita (tiedot voit alustaa suoraan koodista, ei tarvitse kysyä 
käyttäjältä) ja tallenna ne levylle. Mieti käytätkö jotain tietorakennetta apunasi. 
Toteuta ohjelmaan myös tiedostonlukeminen ja tulosta TV-oliot näkyville.

Harjoitellaan sarjallistamista (Serialization).

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
    [Serializable]          // Sarjallisestaan luokka, jotta voidaan kirjoittaa tiedostoon
    class Ohjelma
    {
        public string OhjelmanNimi { get; set; }
        public int Kanava { get; set; }
        public string Alkuaika { get; set; }
        public string Loppuaika { get; set; }
        public string Infoteksti { get; set; }

        public override string ToString()
        {
            return OhjelmanNimi + " alkaa kanavalla " + Kanava + " kello " + Alkuaika + " ja päättyy kello " + Loppuaika + ". Ohjelman kuvaus: " + Infoteksti;
        }
    }
}
