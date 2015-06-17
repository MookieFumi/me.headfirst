using System;

namespace me.headfirst.Observer.Framework.Displays
{
    public class CurrentConditionsDisplayV2: IObserver<WeatherInfo>, IDisplayElement
    {
        private WeatherInfo _weatherInfo;

        public CurrentConditionsDisplayV2(IObservable<WeatherInfo> observable)
        {
            observable.Subscribe(this);
        }

        #region IDisplayElement members

        public void Display()
        {
            var value = String.Format("Current conditions: {0}º and humidity {1}% [V2]",
                Utilities.FloatToString(_weatherInfo.Temperature),
                Utilities.FloatToString(_weatherInfo.Humidity));
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
            _weatherInfo = weatherInfo;
            Display();
        }

        #endregion
    }
}
