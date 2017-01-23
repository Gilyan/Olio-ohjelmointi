/* **************************************
Harjoitellaan koostamista.

Luotu 23.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;
using System.Collections.Generic;

namespace JAMK.IT
{
    public class Kylmakaappi
    {
        public string Tavara { get; set; }
        public string ParastaEnnen { get; set; }
        public string Ostettu { get; set; }
        public List<Kylmakaappi> Tavarat { get; }
        public Kylmakaappi()
        {
            Tavarat = new List<Kylmakaappi>();
        }

        public void LisaaRuokaa(Kylmakaappi kaappi)
        {
            Tavarat.Add(kaappi);
            Console.WriteLine("Tavara {0} lisätty jääkaappiin {1}", kaappi.Tavara);
        }

        public override string ToString()
        {
            string tulosta = Tavara + ", ostettu: " + Ostettu + ", parasta ennen: " + ParastaEnnen;
            foreach (Kylmakaappi r in Tavarat)
            {
                if (r != null) tulosta += "\n- " + r.ToString();
            }
            return tulosta;

            //return Tavara + ", ostettu: " + Ostettu + ", parasta ennen: " + ParastaEnnen;
        }
    }
    class Hedelma : Kylmakaappi
    {
        public string Vari { get; set; }
        public override string ToString()
        {
            return Vari + " " + base.ToString();
        }
    }

    class Maito : Kylmakaappi
    {
        public bool OnkoLoppu { get; set; }     // true = on loppu
        public override string ToString()
        {
            if (OnkoLoppu == true)
            { return base.ToString() + " LOPUSSA, osta lisää!"; }
            else
            { return base.ToString() + " ei ole loppu, kaikki hyvin."; }
        }
        public Maito(string item, string bestBefore, string bought, bool empty)
        {
            Tavara = item;
            ParastaEnnen = bestBefore;
            Ostettu = bought;
            OnkoLoppu = empty;
        }
    }

}
