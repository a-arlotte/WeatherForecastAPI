using NUnit.Framework;
using APIDeployTest;
using System;
using System.Linq;
using System.Collections.Generic;
using WeatherForecastAPI.Controllers;
using WeatherForecastLibrary;
using Microsoft.Extensions.Logging;

namespace WeatherForecastTest
{
    [TestFixture]
    public class Tests
    {

        WeatherForecastController controller;


        [SetUp]
        public void Setup()
        {
            Logger<WeatherForecastController> logger = new Logger<WeatherForecastController>(new LoggerFactory());
            controller = new WeatherForecastController(logger);
        }


        [Test]
        public void GetAllWeatherForecasts_ShouldReturnAllForecasts()
        {

            //Arrange
            //controller arranged
            //Act

            //Assert
            Assert.That(controller.GetAll().Count() == 4);
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