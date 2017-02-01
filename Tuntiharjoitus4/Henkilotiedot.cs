/* **************************************
Harjoitellaan get- ja set -aksessorien käyttöä sekä perintää.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public Employee() { }           // Oletuskonstruktori

        public override string ToString()
        {
            return Name + ", " + Profession + ", " + Salary + " euroa";
        }
    }

    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", " + Car + ", " + Bonus + " euroa";
        }
    }
}
