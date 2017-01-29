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
    class Kortti
    {
        public string Maa { get; set; }
        public string Numero { get; set; }

        public override string ToString()
        {
            return Maa + " " + Numero;
        }
    }

}
