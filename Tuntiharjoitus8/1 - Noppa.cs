/* **************************************
Kertaamista.

Toiminta: Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku 
jokaisella heittokerralla. Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran 
ja tulosta nopan luku. Toteuta tämän jälkeen ohjelma siten, että kysyt käyttäjältä heittojen määrän. 
Heitä noppaa ja tulosta heittojen lukujen keskiarvo.

Esimerkkitulostus:

    Dice, one test throw value is 4
    
    How many times you want to throw a dice :  10000
    Dice is now thrown 10000 times, average is 3,4853
    
Tulosta lopuksi kaikkien heitettyjen lukujen esiintymismäärät.

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
    class Noppa
    {
        public int Arvo { get; set; }

        public int HeitaNoppaa(int silmaluku)
        {
            Random rand = new Random();
            silmaluku = rand.Next(1,6);
            return silmaluku;
        }
    }
}
