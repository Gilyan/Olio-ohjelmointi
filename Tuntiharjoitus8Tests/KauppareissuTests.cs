using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class KauppareissuTests
    {
        [TestMethod()]
        public void LaskeLoppusummaTest()
        {
            // Arrange (alustetaan tiedot)
            Kauppareissu testi = new Kauppareissu();     
            double expected = 16.90;

            // Act (kutsutaan metodia)
            testi.LisaaTuote(new Ostos { Nimi = "Maitopurkki 1l", Hinta = 1.20, Maara = 2 }); // = 2,40
            testi.LisaaTuote(new Ostos { Nimi = "Jauheliha 400g", Hinta = 3.00, Maara = 1 }); // = 3
            testi.LisaaTuote(new Ostos { Nimi = "Spagetti 1kg", Hinta = 2.50, Maara = 3 });   // = 7,50
            testi.LisaaTuote(new Ostos { Nimi = "Talouspaperi", Hinta = 4.00, Maara = 1 });   // = 4 --> yht 16,90

            double actual = testi.Loppusumma;

            // Assert (varmistetaan että tulos ok)
            Assert.AreEqual(expected, actual);      // Assert
        }
    }
}