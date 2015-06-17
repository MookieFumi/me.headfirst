using System;

namespace me.headfirst.Observer.Custom.Displays
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _accumulatedTemperature;
        private float _maxTemperature;
        private float _minTemperature = 200;
        private int _readingsNumber;

        public StatisticsDisplay(ISubject observable)
        {
            _readingsNumber = 0;
            observable.RegisterObserver(this);
        }

        #region IDisplayElement members

        public void Display()
        {
            var averageTemperature = _accumulatedTemperature / _readingsNumber;
            var value = String.Format("Temperature. Avg {0}/ Max {1}/ Min {2}", 
                Utilities.FloatToString(averageTemperature),
                Utilities.FloatToString(_maxTemperature),
                Utilities.FloatToString(_minTemperature));
            Console.WriteLine(value);
        }

        #endregion

        #region IObserver members

        public void Update(float temperature, float humidity)
        {
            _accumulatedTemperature += temperature;
            _readingsNumber++;

            if (temperature > _maxTemperature)
            {
                _maxTemperature = temperature;
            }

            if (temperature < _minTemperature)
            {
                _minTemperature = temperature;
            }
            Display();
        }

        #endregion
    }
}