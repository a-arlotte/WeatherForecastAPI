using NUnit.Framework;
using APIDeployTest;
using System;
using System.Linq;
using System.Collections.Generic;
using APIDeployTest.Controllers;

namespace WeatherForecastTest
{
    [TestFixture]
    public class Tests
    {

        WeatherForecastController controller;


        [SetUp]
        public void Setup()
        {
            controller = new WeatherForecastController();
        }


        [Test]
        public void GetAllWeatherForecasts_ShouldReturnAllForecasts()
        {

            //Arrange
            //controller arranged
            //Act

            //Assert
            Assert.That(controller.GetAllWeatherForecasts().Count() == 4);
        }

        [Test]
        public void GetFirstChilly_IsNotNull()
        {

            //Arrange
            //controller arranged
            //Act
            WeatherForecast chilly = controller.GetFirstChilly();

            //Assert
            Assert.IsNotNull(chilly);
        }

        [Test]
        public void GetFirstChilly_ShouldReturnChillyForecast()
        {

            //Arrange
            //controller arranged
            //Act
            WeatherForecast chilly = controller.GetFirstChilly();

            //Assert
            Assert.That(chilly.Summary =="Chilly");
        }

    }
}