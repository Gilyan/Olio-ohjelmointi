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
    public class ArrayCalcsTests
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

        [TestMethod()]
        public void SumTest()
        {
            double expected = 25.60;                // Arrange

            double actual = array.Sum();            // Act

            Assert.AreEqual(expected, actual);      // Assert
        }

        [TestMethod()]
        public void AverageTest()
        {
            double expected = 3.66;

            double actual = array.Average();
            actual = Math.Round(actual, 2);         // Pyöristetään - HUOM! PYÖRISTYSVIRHE MAHDOLLINEN

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            double expected = -4.50;

            double actual = array.Min();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double expected = 12.00;

            double actual = array.Max();

            Assert.AreEqual(expected, actual);
        }
    }
}