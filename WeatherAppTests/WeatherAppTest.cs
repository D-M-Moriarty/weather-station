using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherAppBusinessLayer;

namespace WeatherAppTests
{
    [TestClass]
    public class WeatherAppTest
    {
     
            private WeatherModel Weather = new WeatherModel();

            [TestMethod]
            public void TestSetandGetTemperature()
            {
                Weather.Temperature = 30;

                int result = Weather.Temperature;
                int expectedResult = 30;

                Assert.AreEqual(result, expectedResult);
            }

            [TestMethod]
            public void TestSetandGetHumidity()
            {
                Weather.Humidity = 50;

                int result = Weather.Humidity;
                int expectedResult = 50;

                Assert.AreEqual(result, expectedResult);
            }

            [TestMethod]
            public void TestSetandGetPressure()
            {
                Weather.Pressure = 1000;

                int result = Weather.Pressure;
                int expectedResult = 1000;

                Assert.AreEqual(result, expectedResult);
            }


        


        [TestMethod]
        public void TestConvertBarometricPressureToMillibars()
        {
            double pascal = 1000;
            double result = BusinessControl.ConvertToMillibars(pascal);
            double expectedResult = 10;
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestConvertTemperaturetoFahrenheit()
        {
            double celsius = 25;
            double result = BusinessControl.ConvertFromCelsiustoFahrenheit(celsius);
            double expectedResult = 77;
            Assert.AreEqual(result, expectedResult);
        }
    }
}
