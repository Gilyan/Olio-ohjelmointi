/* **************************************
Harjoitellaan periytymistä ja abstraktien metodien käyttämistä.

Luotu 23.1.2017

Minttu Mäkäläinen K8517 @ JAMK 
************************************** */

using System;
using System.Collections.Generic;

namespace JAMK.IT
{
    abstract class Nisakas
    {
        public int Ika { get; set; }

        public abstract void Liiku();   // Abstrakti metodi

        public override string ToString()
        {
            return "Ikä: " + Ika;
        }
    }

    class Ihminen : Nisakas
    {
        public int Paino { get; set; }
        public int Pituus { get; set; }
        public string Nimi { get; set; }

        public override void Liiku()
        {
            Console.WriteLine("Liikun.");
        }

        public void Kasva()
        {
            base.Ika++;
        }

        public override string ToString()
        {
            return base.ToString() + ", Nimi: " + Nimi + ", pituus: "+ Pituus + ", paino: " + Paino;
        }
    }

    class Vauva : Ihminen
    {
        string Vaippa { get; set; }

        public Vauva(int ika, int weight, int height, string name, string diaper)
        {
            Ika = ika;
            Paino = weight;
            Pituus = height;
            Nimi = name;
            Vaippa = diaper;
        }

        public override void Liiku()
        {
            Console.WriteLine("Konttaan.");
        }

        public override string ToString()
        {
            return base.ToString() + ", vaippa: " + Vaippa;
        }
    }

    class Aikuinen : Ihminen
    {
        string Auto { get; set; }

        public Aikuinen(int ika, int weight, int height, string name, string car)
        {
            Ika = ika;
            Paino = weight;
            Pituus = height;
            Nimi = name;
            Auto = car;
        }

        public override void Liiku()
        {
            Console.WriteLine("Kävelen.");
        }

        public override string ToString()
        {
            return base.ToString() + ", auto: " + Auto;
        }
    }
}
