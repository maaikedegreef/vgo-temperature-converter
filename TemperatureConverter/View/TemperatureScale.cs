using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TemperatureScale
    {

        public class KelvinTemperatureScale : ITemperatureScale
        {
            // shortened syntax for getter that consits of a sole return statement
            public string Name => "Kelvin";

            public double ConvertFromKelvin(double temperature)
            {
                return temperature;
            }

            public double ConvertToKelvin(double temperature)
            {
                return temperature;
            }
        }

        public class CelsiusTemperatureScale : ITemperatureScale
        {
            // shortened syntax for getter that consits of a sole return statement
            public string Name => "Celsius";

            public double ConvertFromKelvin(double temperature)
            {
                return temperature - 273.15;
            }

            public double ConvertToKelvin(double temperature)
            {
                return temperature + 273.15;
            }
        }

        public class FahrenheitTemperatureScale : ITemperatureScale
        {
            // shortened syntax for getter that consits of a sole return statement
            public string Name => "Fahrenheit";

            public double ConvertFromKelvin(double temperature)
            {
                return 1.8 * (temperature - 273) + 32; ;
            }

            public double ConvertToKelvin(double temperature)
            {
                return (5 / 9) * temperature + 459.67;
            }
        }
    }
}
