using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WeatherAppBusiness;

namespace WeatherAppTests
{
    [TestClass]
    public class TestWeatherApp
    {
        [TestMethod]
        public void TestConvertBarometricPressureToMillibars()
        {
            double pascal = 1000;
            double result = BusinessController.ConvertToMillibars(pascal);
            double expectedResult = 10;
            Assert.AreEqual(result,expectedResult);
        }

        [TestMethod]
        public void TestConvertTemperaturetoFahrenheit()
        {
            double celsius = 25;
            double result = BusinessController.ConvertFromCelsiustoFahrenheit(celsius);
            double expectedResult = 77;
            Assert.AreEqual(result, expectedResult);
        }
    }
}
