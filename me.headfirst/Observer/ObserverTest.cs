using System;
using me.headfirst.Observer.Custom;
using me.headfirst.Observer.Custom.Displays;
using me.headfirst.Observer.Framework;
using me.headfirst.Observer.Framework.Displays;
using NUnit.Framework;

namespace me.headfirst.Observer
{
    public class ObserverTest
    {
        private Random _random;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
           _random = new Random();
        }

        [Test]
        public void WeatherStationTest()
        {
            var wheatherData = new WheatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(wheatherData);
            var statisticsDisplay = new StatisticsDisplay(wheatherData);

            wheatherData.SetMeasurements(GetRandomFloat(), GetRandomFloat());
            wheatherData.SetMeasurements(GetRandomFloat(), GetRandomFloat());
        }

        [Test]
        public void WeatherStationV2Test()
        {
            var weatherDataV2 = new WeatherDataV2();
            var currentConditionsDisplayV2 = new CurrentConditionsDisplayV2(weatherDataV2);
            var statisticsDisplayV2 = new StatisticsDisplayV2(weatherDataV2);

            weatherDataV2.SetMeasurements(new WeatherInfo(GetRandomFloat(), GetRandomFloat()));
            weatherDataV2.SetMeasurements(new WeatherInfo(GetRandomFloat(), GetRandomFloat()));
        }

        private float GetRandomFloat()
        {
            return (float) _random.NextDouble()*100;
        }

    }
}
