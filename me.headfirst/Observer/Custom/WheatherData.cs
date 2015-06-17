using System.Collections.ObjectModel;

namespace me.headfirst.Observer.Custom
{
    public class WheatherData : ISubject
    {
        private readonly Collection<IObserver> _observers;
        private float _humidity;
        private float _temperature;

        public WheatherData()
        {
            _observers = new Collection<IObserver>();
        }

        #region ISubject members

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            var index = _observers.IndexOf(observer);
            if (index >= 0)
            {
                _observers.RemoveAt(index);
            }
        }

        #endregion

        public void SetMeasurements(float temperature, float humidity)
        {
            _temperature = temperature;
            _humidity = humidity;
            MeasurementChanged();
        }

        private void MeasurementChanged()
        {
            NotifyObservers();
        }
    }
}