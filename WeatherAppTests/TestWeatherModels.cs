using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WeatherAppBusiness;
using WeatherAppModels;

namespace WeatherAppTests
{
    [TestClass]
    public class TestWeatherModels
    {
        WeatherModels Weather = new WeatherModels();

        [TestMethod]
        public void TestSetandGetTemperature()
        {
            Weather.Temperature = 30;

            int result = Temperature;
            int expectedResult = 30;

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestSetandGetHumidity()
        {
            Weather.Humidity = 50;

            int result = Humidity;
            int expectedResult = 50;

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestSetandGetPressure()
        {
            Weather.Pressure = 1000;

            int result = Pressure;
            int expectedResult = 1000;
            
            Assert.AreEqual(result, expectedResult);
        }

    }
}
