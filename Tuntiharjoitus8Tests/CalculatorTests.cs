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
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()       // Testataan yhteenlaskumetodia
        {
            /// AAA-periaate:
            /// Arrange (alustetaan tiedot)
            /// Act (kutsutaan metodia)
            /// Assert (varmistetaan että tulos ok)

            Calculator calc = new Calculator();     // Arrange
            int a = 4, b = 5, expected = 9;

            int actual = calc.Add(a, b);            // Act

            Assert.AreEqual(expected, actual);      // Assert

            // Tehdään sama testi eri arvoilla
            a = 0;
            b = 1;
            expected = 1;

            actual = calc.Add(a, b);            // Act

            Assert.AreEqual(expected, actual);      // Assert
        }

        [TestMethod()]
        public void MultiplyTest()  // Testataan kertolaskumetodia
        {
            Calculator calc = new Calculator();     // Arrange
            int a = 4, b = 5, expected = 20;

            int actual = calc.Multiply(a, b);       // Act

            Assert.AreEqual(expected, actual);      // Assert

            // Tehdään sama testi eri arvoilla
            a = 0;
            b = 1;
            expected = 0;

            actual = calc.Multiply(a, b);           // Act

            Assert.AreEqual(expected, actual);      // Assert
        }

        [TestMethod()]
        public void DivisionTest()  // Testataan jakolaskumetodia
        {
            Calculator calc = new Calculator();     // Arrange
            int a = 10, b = 2, expected = 5;

            int actual = calc.Division(a, b);       // Act

            Assert.AreEqual(expected, actual);      // Assert

            // Tehdään sama testi eri arvoilla
            a = 100;
            b = 2;
            expected = 50;

            actual = calc.Division(a, b);           // Act

            Assert.AreEqual(expected, actual);      // Assert
        }

        [TestMethod()]
        public void SubstractTest() // Testataan vähennyslaskumetodia
        {
            Calculator calc = new Calculator();     // Arrange
            int a = 10, b = 2, expected = 8;

            int actual = calc.Substract(a, b);       // Act

            Assert.AreEqual(expected, actual);      // Assert

            // Tehdään sama testi eri arvoilla
            a = 25;
            b = 15;
            expected = 10;

            actual = calc.Substract(a, b);           // Act

            Assert.AreEqual(expected, actual);      // Assert
        }
    }
}

namespace Tuntiharjoitus8Tests
{
    class CalculatorTests
    {
    }
}
