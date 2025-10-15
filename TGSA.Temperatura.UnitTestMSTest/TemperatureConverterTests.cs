using Microsoft.VisualStudio.TestTools.UnitTesting;
using TGSA.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGSA.Temperatura.Tests
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private TemperatureConverter _conv;

        [TestInitialize]
        public void Setup()
        {
            _conv = new TemperatureConverter();
        }

        // TC-1001: 0°C → 32°F
        [TestMethod]
        public void CelsiusToFahrenheit_0C_Returns32F()
        {
            // Arrange
            double celsius = 0;

            // Act
            double result = _conv.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(32.0, result, 0.0001);
        }

        // TC-1002: 100°C → 212°F
        [TestMethod]
        public void CelsiusToFahrenheit_100C_Returns212F()
        {
            double result = _conv.CelsiusToFahrenheit(100);
            Assert.AreEqual(212.0, result, 0.0001);
        }

        // TC-1003: 32°F → 0°C
        [TestMethod]
        public void FahrenheitToCelsius_32F_Returns0C()
        {
            double result = _conv.FahrenheitToCelsius(32);
            Assert.AreEqual(0.0, result, 0.0001);
        }

        // TC-1004: 212°F → 100°C
        [TestMethod]
        public void FahrenheitToCelsius_212F_Returns100C()
        {
            double result = _conv.FahrenheitToCelsius(212);
            Assert.AreEqual(100.0, result, 0.0001);
        }
    }
}