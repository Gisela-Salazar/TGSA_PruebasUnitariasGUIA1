using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGSA.Temperatura
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            // Fórmula: (°C × 9/5) + 32
            return (celsius * 9.0 / 5.0) + 32.0;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            // Fórmula: (°F − 32) × 5/9
            return (fahrenheit - 32.0) * 5.0 / 9.0;
        }
    }
}
