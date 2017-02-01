/* **************************************
Kertaamista.

Toiminta: Toteuta ohjelma, jossa voidaan näyttää lasku ostetuista tavaroista.

Jokaisesta ostetusta tavarasta tulee käsitellä seuraavat tiedot: 
nimi, hinta ja määrä. 

Toteutetun luokan tulee osata palauttaa tieto siitä paljonko ko. ostetut tavarat 
kokonaisuudessaan maksavat (hinta*määrä). Toteuta myös ToString()-metodi, joka 
palauttaa tuotteen nimen, hinnan ja määrät merkkijonona.

    InvoiceItem
    - Name : String
    - Price : double
    - Quantity : int
    - Total == Price * Quantity : double
    - ToString() : string
    
Toteuta luokka, joka pitää sisällään List-rakenteessa yllä määriteltyjä tuotteita. 
Luokan tulee pystyä kertomaan myös asiakkaan nimi, paljonko "laskulla" on yhteensä 
tuotteita sekä niihin kuluva rahan määrä kokonaisuudessaan.

    Invoice
    - Customer : string (just a string, no Customer class..)
    - List<InvoiceItem>
    - Total ("sum of InvoiceItem Total's") : string
    - PrintInvoice() ("prints invoice to screen")
    
Toteuta pääohjelma ja määrittele laskulle tavaroita ja ostajan nimi.

Esimerkkitulostus:

    Customer Kirsi Kernel's invoice:
    =================================
    Milk   1,75e 1 pieces 1,75e total
    Beer   5,25e 1 pieces 5,25e total
    Butter 2,50e 2 pieces 5,00e total
    =================================
    Total : 12,00 euros
    
Invoice-luokan kokonaissumman (total) testaaminen:

Testaa yksikkötestauksen avulla, että laskulle määritelty kokonaissumma varmasti lasketaan oikein.

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

}
