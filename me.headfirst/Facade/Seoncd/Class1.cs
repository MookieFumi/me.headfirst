using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace me.headfirst.Facade.Seoncd
{
    //Talk only to your immediate friends
    class ImmediateFriends
    {
        private readonly Station _station;

        public ImmediateFriends(Station station)
        {
            _station = station;
        }

        public float GetTempWithoutPrinciple()
        {
            Thermometer thermometer = _station.GetThermomiter();
            return thermometer.GetTemperature();
        }

        public float GetTemp()
        {
            return _station.GetTemperature();
        }
    }

    class Station
    {
        private readonly Thermometer _thermometer;

        public Station(Thermometer thermometer)
        {
            _thermometer = thermometer;
        }

        public float GetTemperature()
        {
            return _thermometer.GetTemperature();
        }

        public Thermometer GetThermomiter()
        {
            return _thermometer;
        }
    }

    class Thermometer
    {
        public float GetTemperature()
        {
            return 27.3f;
        }
    }
}
