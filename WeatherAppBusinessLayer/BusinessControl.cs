using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppBusinessLayer
{
    public class BusinessControl
    {
        /// <summary>
        /// This method converts pascal to millibars
        /// </summary>
        /// <param name="pascal"></param>
        public static double ConvertToMillibars(double pascal)
        {
            return pascal / 100;
        }

        /// <summary>
        /// This method converts celsius to fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns>Fahrenheit</returns>
        public static double ConvertFromCelsiustoFahrenheit(double celsius)
        {
            return 32 + (celsius * 9 / 5);
        }
    }
}
