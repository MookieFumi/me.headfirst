using System;

namespace me.headfirst.Observer.Framework.Displays
{
    public class StatisticsDisplayV2 : IObserver<WeatherInfo>, IDisplayElement
    {
        private float _accumulatedTemperature;
        private float _maxTemperature;
        private float _minTemperature = 200;
        private int _readingsNumber;

        public StatisticsDisplayV2(IObservable<WeatherInfo> observable)
        {
            _readingsNumber = 0;
            observable.Subscribe(this);
        }

        #region IDisplayElement members

        public void Display()
        {
            var averageTemperature = _accumulatedTemperature / _readingsNumber;
            var value = String.Format("Temperature. Avg {0}/ Max {1}/ Min {2} [V2]",
                Utilities.FloatToString(averageTemperature),
                Utilities.FloatToString(_maxTemperature),
                Utilities.FloatToString(_minTemperature));
            Console.WriteLine(value);
        }

        #endregion

        #region IObserver<WeatherInfo> members

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(WeatherInfo weatherInfo)
        {
            _accumulatedTemperature += weatherInfo.Temperature;
            _readingsNumber++;

            if (weatherInfo.Temperature > _maxTemperature)
            {
                _maxTemperature = weatherInfo.Temperature;
            }

            if (weatherInfo.Temperature < _minTemperature)
            {
                _minTemperature = weatherInfo.Temperature;
            }
            Display();
        }

        #endregion
    }
}