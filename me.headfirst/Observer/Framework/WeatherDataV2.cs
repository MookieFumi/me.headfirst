using System;
using System.Collections.Generic;

namespace me.headfirst.Observer.Framework
{
    public class WeatherDataV2 : IObservable<WeatherInfo>
    {
        private readonly List<IObserver<WeatherInfo>> _observers;

        public WeatherDataV2()
        {
            _observers = new List<IObserver<WeatherInfo>>();
        }

        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Disposer(_observers, observer);
        }

        public void SetMeasurements(WeatherInfo weatherInfo)
        {
            MeasurementChanged(weatherInfo);
        }

        private void MeasurementChanged(WeatherInfo weatherInfo)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(weatherInfo);
            }
        }

        private class Disposer : IDisposable
        {
            // The observers list recieved from the observable
            private readonly List<IObserver<WeatherInfo>> _subjectObservers;
            // The observer instance to unsubscribe
            private readonly IObserver<WeatherInfo> _observer;

            public Disposer(List<IObserver<WeatherInfo>> _subObservers, IObserver<WeatherInfo> observer)
            {
                _subjectObservers = _subObservers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_subjectObservers.Contains(_observer))
                {
                    _subjectObservers.Remove(_observer);
                }
            }
        }
    }
}