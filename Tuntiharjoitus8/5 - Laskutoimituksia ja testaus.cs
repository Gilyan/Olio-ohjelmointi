﻿/* **************************************
Kertaamista.

Toiminta: Toteuta ArrayCalcs-niminen luokka ja sen sisälle seuraavat staattiset-metodit: 
Sum, Average, Min ja Max. 

Metodit ottavat parametriksi double[]-taulukon ja laskevat nimensä mukaisen laskutoimintuksen 
taulukon alkioille ja palauttavat tuloksen kutsuvalle ohjelmalle.

Toteuta pääohjelma ja esimerkiksi seuraavaa dataa sisältävä taulukko: 
double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 }; 
Kutsu pääohjelmasta ArrayCalcs-luokan staattisia laskutoimituksia tekeviä metodeja annetun 
taulukon arvoilla ja tulosta tulokset näyttölaitteelle.

Esimerkkitulostus:

    Sum = 25,60
    Ave = 3,66
    Min = -4,50
    Max = 12,00

    Press enter key to continue...    
    
ArrayCalcs-luokan metodien testaaminen

Toteuta solutioniin uusi yksikkötestaukseen liittyvä projekti ja testaa ArrayCalcs-luokan kaikki metodit.
Kuinka ArrayCalcs-luokan metodit toimivat, jos välität parametrina tyhjän double[]-taulukon: double[] array = { };

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
    public class ArrayCalcs
    {
        static public double Sum(double[] array)
        {
            return array.Sum();
        }

        static public double Average(double[] array)
        {
            return array.Average();
        }

        static public double Min(double[] array)
        {
            return array.Min();
        }

        static public double Max(double[] array)
        {
            return array.Max();
        }
    }
}
