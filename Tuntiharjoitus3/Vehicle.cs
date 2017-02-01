/* **************************************
Harjoitellaan luokkien ja ominaisuuksien tekoa ja käyttöä.

Luotu 16.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Car name: {0}", Name);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }

        public override string ToString()       // koska ToString löytyy kantaluokasta, ylikirjoitetaan overridella olemassa oleva
        {
            return Name + ", " + Color + ", " + Speed;
        }
    }
}