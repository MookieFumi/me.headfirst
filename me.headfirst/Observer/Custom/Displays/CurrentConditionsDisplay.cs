using System;

namespace me.headfirst.Observer.Custom.Displays
{
    public class CurrentConditionsDisplay: IObserver, IDisplayElement
    {
        private float _humidity;
        private float _temperature;

        public CurrentConditionsDisplay(ISubject observable)
        {
            observable.RegisterObserver(this);
        }

        #region IDisplayElement members

        public void Display()
        {
            var value = String.Format("Current conditions: {0}º and humidity {1}%", Utilities.FloatToString(_temperature), Utilities.FloatToString(_humidity));
            Console.WriteLine(value);
        }

        #endregion

        #region IObserver members

        public void Update(float temperature, float humidity)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        #endregion
    }
}
