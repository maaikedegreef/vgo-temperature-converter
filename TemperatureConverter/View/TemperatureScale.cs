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
    }
}
