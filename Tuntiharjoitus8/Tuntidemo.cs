/* **************************************
Opettajan kanssa yhdessä tehty demo yksikkötestaamisesta.

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
    interface ICalculator
    {
        int Add(int number1, int number2);
        int Multiply(int number1, int number2);
    }

    public class Calculator : ICalculator
    {
        public int Add(int n1, int n2)          // Yhteenlasku
        {
            return n1 + n2;
        }
        public int Multiply(int n1, int n2)     // Kertolasku
        {
            return n1 * n2;
        }
        public int Division(int n1, int n2)     // Jakolasku
        {
            return n1 / n2;
        }
        public int Substract(int n1, int n2)    // Vähennyslasku
        {
            return n1 - n2;
        }
    }
}
